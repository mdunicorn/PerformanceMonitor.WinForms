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

namespace PerfromanceMonitor.WinForms
{
    public partial class CaptureForm : Form
    {
        IReadOnlyList<PerformanceCounter> _counters;

        public CaptureForm(IReadOnlyList<PerformanceCounter> counters)
        {
            InitializeComponent();
            _counters = counters;
        }


    }
}
