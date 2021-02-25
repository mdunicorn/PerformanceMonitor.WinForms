using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using PerformanceMonitor.Model;
using PerfromanceMonitor.WinForms.Model;

namespace PerfromanceMonitor.WinForms
{
    public partial class CaptureForm : Form
    {
        IReadOnlyList<PerformanceCounter> _counters;
        List<CounterController> _controllers = new List<CounterController>();
        const int ChartHeight = 200;
        const int ChartMargin = 5;
        IReadOnlyList<TimeSpanWrapper> _allIntervals =
            new List<TimeSpanWrapper>()
            {
                new TimeSpanWrapper(500, "0.5 seconds"),
                new TimeSpanWrapper(1000, "1 second"),
                new TimeSpanWrapper(2000, "2 second"),
                new TimeSpanWrapper(5000, "5 seconds"),
            };
        IReadOnlyList<TimeSpanWrapper> _allRanges =
            new List<TimeSpanWrapper>()
            {
                new TimeSpanWrapper(TimeSpan.FromMinutes(1), "1 minute"),
                new TimeSpanWrapper(TimeSpan.FromMinutes(5), "5 minutes"),
                new TimeSpanWrapper(TimeSpan.FromMinutes(10), "10 minutes"),
                new TimeSpanWrapper(TimeSpan.FromMinutes(20), "20 minutes"),
                new TimeSpanWrapper(TimeSpan.FromMinutes(60), "1 hour"),
            };

        public CaptureForm(IEnumerable<PerformanceCounter> counters)
        {
            InitializeComponent();

            _counters = counters.ToList().AsReadOnly();

            InitSamplingInterval();
            InitTimeRnage();
            InitCharts();

            cbRange.SelectedIndexChanged += new EventHandler(this.cbRange_SelectedIndexChanged);
            cbSamplingInterval.SelectedIndexChanged += new EventHandler(this.cbSamplingInterval_SelectedIndexChanged);
        }

        private void InitSamplingInterval()
        {
            cbSamplingInterval.DataSource = _allIntervals;
            var interval = Configuration.Instance.SamplingInterval;
            var nearest = FindNearest(_allIntervals, interval);
            cbSamplingInterval.SelectedItem = nearest;
            SetSamplingInterval(nearest.Value);
        }

        private void InitTimeRnage()
        {
            cbRange.DataSource = _allRanges;
            var range = Configuration.Instance.VisibleTimeRange;

            var nearest = FindNearest(_allRanges, range);
            cbRange.SelectedItem = nearest;
            SetVisibleTimeRange(nearest.Value);
        }

        private TimeSpanWrapper FindNearest(IReadOnlyList<TimeSpanWrapper> source, TimeSpan timeSpan)
        {
            int i = 0;
            while (i < source.Count && timeSpan < source[i].Value)
                i++;
            if (i == source.Count)
                return source.Last();
            if (timeSpan == source[i].Value || i == source.Count - 1)
                return source[i];
            if ((timeSpan - source[i].Value) < (source[i + 1].Value - timeSpan))
                return source[i];
            return source[i + 1];
        }

        private void InitCharts()
        {
            int chartWidth = panelCharts.Width - 2 * ChartMargin;
            int y = ChartMargin;
            foreach (var counter in _counters)
            {
                var controller = new CounterController(counter);
                _controllers.Add(controller);
                Label label = new Label();
                label.AutoSize = true;
                label.Text = Helpers.GetCounterTitle(counter);
                label.Location = new Point(ChartMargin, y);
                y += label.Height;
                var chart = controller.Chart.Chart;
                chart.Location = new Point(ChartMargin, y);
                chart.Size = new Size(chartWidth, ChartHeight);
                chart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                y += ChartHeight + ChartMargin;
                panelCharts.Controls.Add(label);
                panelCharts.Controls.Add(chart);
                controller.Start();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            foreach (var controller in _controllers)
                controller.Stop();
        }

        private void cbSamplingInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            var interval = ((TimeSpanWrapper)cbSamplingInterval.SelectedItem).Value;
            SetSamplingInterval(interval);
            Configuration.Instance.SamplingInterval = interval;
            Configuration.Instance.Save();
        }

        private void SetSamplingInterval(TimeSpan interval)
        {
            SamplingTimer.Instance.SamplingInterval = interval;
        }

        private void SetVisibleTimeRange(TimeSpan value)
        {
            foreach (var c in _controllers)
                c.Chart.VisibleTimeRange = value;
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            var range = ((TimeSpanWrapper)cbRange.SelectedItem).Value;
            SetVisibleTimeRange(range);
            Configuration.Instance.VisibleTimeRange = range;
            Configuration.Instance.Save();
        }

        private class TimeSpanWrapper
        {
            public TimeSpanWrapper(int milliseconds, string text)
                : this(TimeSpan.FromMilliseconds(milliseconds), text)
            {
            }

            public TimeSpanWrapper(TimeSpan value, string text)
            {
                Value = value;
                Text = text;
            }

            public TimeSpan Value { get; }
            public string Text { get; }

            public override string ToString()
                => Text;
        }
    }
}
