using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfromanceMonitor.WinForms
{
    public static class Helpers
    {
        public static string GetCounterTitle(PerformanceCounter counter)
            => $"{counter.CategoryName} | {counter.InstanceName} | {counter.CounterName} ({counter.CounterType})";
    }
}
