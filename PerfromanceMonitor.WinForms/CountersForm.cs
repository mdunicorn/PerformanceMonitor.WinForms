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
    public partial class CountersForm : Form
    {
        private CountersFormViewModel _viewModel;

        public CountersForm(CountersFormViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            mainWindowViewModelBindingSource.DataSource = _viewModel;
            lstCategories.DataSource = _viewModel.Categories;
        }

        public IEnumerable<PerformanceCounter> SelectedCounters
        {
            get => lstCounters.SelectedItems.Cast<PerformanceCounter>();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
