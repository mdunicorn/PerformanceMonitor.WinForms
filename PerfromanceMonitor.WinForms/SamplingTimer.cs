using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfromanceMonitor.WinForms
{
    public class SamplingTimer
    {
        private System.Timers.Timer? _timer;
        private TimeSpan _samplingInterval;

        public TimeSpan SamplingInterval
        {
            get => TimeSpan.FromMilliseconds(_timer.Interval);
            set => _timer.Interval = value.TotalMilliseconds;
        }

        public Dictionary<string, Action> _actions = new Dictionary<string, Action>();

        public static SamplingTimer Instance { get; } = new SamplingTimer();

        public SamplingTimer()
        {
            _timer = new System.Timers.Timer();
            _timer.Elapsed += timer_Elapsed;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (var action in _actions.Values.ToList())
                action();
        }

        public void SetTimer(string key, Action action)
        {
            if (SamplingInterval == default)
                throw new Exception("Set the sampling interval first.");

            _actions[key] = action;
            if (!_timer.Enabled)
            {
                _timer.Interval = SamplingInterval.TotalMilliseconds;
                _timer.Start();
            }
        }

        public void RemoveTimer(string key)
        {
            _actions.Remove(key);
            if (_actions.Count == 0)
                _timer.Stop();
        }

    }
}
