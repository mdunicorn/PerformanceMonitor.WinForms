using PerformanceMonitor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfromanceMonitor.WinForms
{
    public partial class MainForm : Form
    {
        private ManualResetEvent _countersViewModelWaitHandle = new ManualResetEvent(false);
        private CountersFormViewModel _countersFormViewModel;

        public MainForm()
        {
            CreateCountersViewModel();
            InitializeComponent();
            InitializeCounters();
        }
        public CountersFormViewModel CountersFormViewModel
        {
            get
            {
                if (_countersFormViewModel == null)
                {
                    _countersViewModelWaitHandle.WaitOne();
                }
                return _countersFormViewModel;
            }
        }

        private void CreateCountersViewModel()
        {
            Task.Run(() =>
            {
                _countersFormViewModel = new CountersFormViewModel();
                _countersViewModelWaitHandle.Set();
            });
        }

        private void InitializeCounters()
        {
            foreach (var (category, instance, counter) in Configuration.Instance.Counters)
            {
                if (!PerformanceCounterCategory.Exists(category))
                    throw new InvalidOperationException("Category does not exist");
                if (!PerformanceCounterCategory.CounterExists(counter, category))
                    throw new InvalidOperationException("Counter does not exist");
                var inst = instance;
                if (instance == null) inst = ""; // "" == no instance (not null!)
                if (inst != "" &&
                    !PerformanceCounterCategory.InstanceExists(inst ?? "", category))
                    throw new InvalidOperationException("Instance does not exist");
                lstAddedCounters.Items.Add(new PerformanceCounter(category, counter, inst));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new CountersForm(CountersFormViewModel);
            if (form.ShowDialog() == DialogResult.OK)
            {
                bool alreadyAdded = false;
                foreach (var counter in form.SelectedCounters)
                {
                    if (lstAddedCounters.Items.Cast<PerformanceCounter>().Any(c => CounterEquals(counter, c)))
                        alreadyAdded = true;
                    else
                        lstAddedCounters.Items.Add(counter);
                }
                if (alreadyAdded)
                    toolTipDuplicate.Show("Some counters are already added.", this, 0, 0, 3000);
            }
            SaveCountersInConfig();
        }

        private void SaveCountersInConfig()
        {
            SaveCountersInConfig(lstAddedCounters.Items.Cast<PerformanceCounter>());
        }

        private void SaveCountersInConfig(IEnumerable<PerformanceCounter> counters)
        {
            var list = new List<(string, string, string)>();
            foreach (var counter in counters)
            {
                list.Add((counter.CategoryName, counter.InstanceName, counter.CounterName));
            }
            Configuration.Instance.Counters = list;
            Configuration.Instance.Save();
        }

        private bool CounterEquals(PerformanceCounter c1, PerformanceCounter c2)
        {
            return c1.CategoryName == c2.CategoryName
                && c1.InstanceName == c2.InstanceName
                && c1.CounterName == c2.CounterName;
        }

        private void lstAddedCounters_Format(object sender, ListControlConvertEventArgs e)
        {
            var counter = (PerformanceCounter)e.ListItem;
            e.Value = Helpers.GetCounterTitle(counter);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var form = new CaptureForm(lstAddedCounters.Items.Cast<PerformanceCounter>());
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in lstAddedCounters.SelectedItems.Cast<PerformanceCounter>().ToList())
            {
                lstAddedCounters.Items.Remove(item);
            }
            SaveCountersInConfig();
        }
    }
}
