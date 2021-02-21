using PerformanceMonitor.Model;
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
    public partial class MainForm : Form
    {
        private MainWindowViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();

            _viewModel = new MainWindowViewModel();
            mainWindowViewModelBindingSource.DataSource = _viewModel;
            lstCategories.DataSource = _viewModel.Categories;
        }

        private void lstCounters_SelectedIndexChanged(object sender, EventArgs e)
        {
            _viewModel.CurrentCounters = lstCounters.SelectedItems.Cast<PerformanceCounter>().ToList();
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (IsHandleCreated)
            //    this.Invoke(new Action(() =>
            //    {
            //        lstInstances.Refresh();
            //        lstCounters.Refresh();
            //    }));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool alreadyAdded = false;
            foreach (var newCounter in _viewModel.CurrentCounters)
            {
                if (_viewModel.AddedCounters.Any(c => CounterEquals(newCounter, c)))
                    alreadyAdded = true;
                else
                    _viewModel.AddedCounters.Add(newCounter);
            }
            if (alreadyAdded)
                toolTipDuplicate.Show("Some counters are already added.", lstCounters, 0, 0, 3000);
        }

        private bool CounterEquals(PerformanceCounter c1, PerformanceCounter c2)
        {
            return c1.CategoryName == c2.CategoryName
                && c1.InstanceName == c2.InstanceName
                && c1.CounterName == c2.CounterName;
        }

        private void lstAddedCounters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var counter = (PerformanceCounter)lstAddedCounters.SelectedItem;
            if (counter == null)
                lblSelCounterInfo.Text = null;
            else
                lblSelCounterInfo.Text = $"{counter.CategoryName} | {counter.InstanceName} | {counter.CounterName} ({counter.CounterType})";
        }
    }
}
