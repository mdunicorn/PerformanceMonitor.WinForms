using LiveCharts;
using LiveCharts.Wpf;
using PerfromanceMonitor.WinForms.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfromanceMonitor.WinForms
{
    public class CounterController
    {
        private string _key;
        public PerformanceCounter Counter { get; }
        public SamplingChart Chart { get; }
        public string Key => _key;
        readonly IReadOnlyCollection<PerformanceCounterType> _percentageTypes = new List<PerformanceCounterType>()
        {
            PerformanceCounterType.CounterTimer,
            PerformanceCounterType.CounterTimerInverse,
            PerformanceCounterType.Timer100Ns,
            PerformanceCounterType.Timer100NsInverse
        };

        public CounterController(PerformanceCounter counter)
        {
            Counter = counter;
            _key = $"{Counter.MachineName}${Counter.CategoryName}${Counter.InstanceName}${Counter.CounterName}";
            Chart = new SamplingChart(Key);
            if (_percentageTypes.Contains(Counter.CounterType))
            {
                var axis = Chart.Chart.AxisY.FirstOrDefault();
                if (axis == null)
                    Chart.Chart.AxisY.Add(axis = new Axis());
                axis.MinValue = 0;
                axis.MaxValue = 100;
            }
        }

        public void Start()
        {
            SamplingTimer.Instance.SetTimer(Key, () =>
            {
                var value = Counter.NextValue();
                Chart.AddSample(DateTime.Now, value);
            });
        }

        public void Stop()
        {
            SamplingTimer.Instance.RemoveTimer(Key);
        }
    }
}
