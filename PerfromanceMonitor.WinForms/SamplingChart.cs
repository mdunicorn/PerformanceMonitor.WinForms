using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.WinForms;
using PerfromanceMonitor.WinForms.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axis = LiveCharts.Wpf.Axis;
using LineSeries = LiveCharts.Wpf.LineSeries;

namespace PerfromanceMonitor.WinForms
{
    public class SamplingChart
    {
        private TimeSpan _visibleTimeRange = TimeSpan.FromSeconds(30);

        public string Key { get; }
        public CartesianChart Chart { get; set; }
        public ChartValues<CounterSampleModel> Values { get; set; }
        public TimeSpan VisibleTimeRange {
            get => _visibleTimeRange;
            set
            {
                _visibleTimeRange = value;
                SetAxisLimits();
            }
        }
        static SamplingChart()
        {
            var mapper = Mappers.Xy<CounterSampleModel>()
                .X(model => model.TimeStamp.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Value);           //use the value property as Y

            Charting.For<CounterSampleModel>(mapper);
        }

        public SamplingChart(string key)
        {
            Key = key;
            Chart = new CartesianChart();
            Values = new ChartValues<CounterSampleModel>();
            Chart.Series = new SeriesCollection()
            {
                new LineSeries()
                {
                    Values = Values,
                    StrokeThickness = 1,
                    PointGeometrySize = 1
                }
            };
            Chart.AxisX.Add(new Axis()
            {
                LabelFormatter = value => new DateTime((long)value).ToString("HH:mm:ss"),
                DisableAnimations = true
            });
            Chart.AxisY.Add(new Axis());
            Chart.DisableAnimations = true;
            Chart.BackColor = Color.White;
            VisibleTimeRange = TimeSpan.FromMinutes(5);
            SetAxisLimits();
        }

        public void AddSample(DateTime timeStamp, float value)
        {
            if (Chart.InvokeRequired)
                Chart.Invoke(new Action(() =>
                {
                    add();
                }));
            else
                add();

            void add()
            {
                Values.Add(new CounterSampleModel() { TimeStamp = timeStamp, Value = value });
                SetAxisLimits();
            };

        }

        private void SetAxisLimits()
        {
            var now = DateTime.Now;
            var ticks = VisibleTimeRange.Ticks;
            Chart.AxisX[0].MaxValue = now.Ticks;
            Chart.AxisX[0].MinValue = now.Ticks - ticks;
        }
    }
}
