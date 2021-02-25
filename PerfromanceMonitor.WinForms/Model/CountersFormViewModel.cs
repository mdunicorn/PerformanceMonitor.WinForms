using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace PerformanceMonitor.Model
{
    public class CountersFormViewModel : INotifyPropertyChanged
    {
        private IReadOnlyList<string> _instances = Array.Empty<string>();
        private IReadOnlyList<PerformanceCounter> _counters = Array.Empty<PerformanceCounter>();
        private PerformanceCounterCategory? _currentCategory;
        private string? _currentInstance;
        private PerformanceCounter? _currentCounter;
        //private IList<PerformanceCounter> _currentCounters = new List<PerformanceCounter>();
        //private IList<PerformanceCounter> _addedCounters = new List<PerformanceCounter>();


        public CountersFormViewModel()
        {
            FillCategories();
        }

        public IReadOnlyList<PerformanceCounterCategory> Categories { get; private set; } = Array.Empty<PerformanceCounterCategory>();
        public PerformanceCounterCategory? CurrentCategory
        {
            get => _currentCategory;
            set
            {
                _currentCategory = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentCategory)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentCategoryHelp)));
                FillInstances(CurrentCategory);
            }
        }

        public string? CurrentCategoryHelp
        {
            get => CurrentCategory?.CategoryHelp;
        }

        public IReadOnlyList<string> Instances
        {
            get => _instances;
            private set
            {
                _instances = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Instances)));
            }
        }

        public string? CurrentInstance
        {
            get
            {
                return _currentInstance;
            }
            set
            {
                _currentInstance = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentInstance)));
                FillCounters(CurrentCategory, CurrentInstance);
            }
        }

        public IReadOnlyList<PerformanceCounter> Counters
        {
            get => _counters;
            set
            {
                _counters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Counters)));
            }
        }

        public PerformanceCounter? CurrentCounter
        {
            get => _currentCounter;
            set
            {
                _currentCounter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentCounter)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentCounterHelp)));
            }
        }

        //public IList<PerformanceCounter> CurrentCounters
        //{
        //    get => _currentCounters;
        //    set
        //    {
        //        _currentCounters = value;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentCounters)));
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentCounterHelp)));
        //    }
        //}

        public string? CurrentCounterHelp
        {
            get => CurrentCounter?.CounterHelp;
        }

        //public IList<PerformanceCounter> AddedCounters { get => _addedCounters; set => _addedCounters = value; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void FillCategories()
        {
            Categories = PerformanceCounterCategory.GetCategories().OrderBy(c => c.CategoryName).ToList().AsReadOnly();
            CurrentCategory = Categories.Count switch
            {
                0 => null,
                _ => Categories[0]
            };
        }

        private void FillInstances(PerformanceCounterCategory? category)
        {
            if (category == null)
                Instances = Array.Empty<string>();
            else
                Instances = category.GetInstanceNames().OrderBy(i => i).ToList().AsReadOnly();
            if (Instances.Count == 0)
                CurrentInstance = null;
            else
                CurrentInstance = Instances[0];
        }

        private void FillCounters(PerformanceCounterCategory? category, string? instance)
        {
            if (category == null)
                Counters = Array.Empty<PerformanceCounter>();
            else
            {
                PerformanceCounter[] cs;
                if (string.IsNullOrEmpty(instance))
                    cs = category.GetCounters();
                else
                    cs = category.GetCounters(instance);
                Counters = cs.OrderBy(c => c.CounterName).ToList().AsReadOnly();
            }
            if (Counters.Count == 0)
                CurrentCounter = null;
            else
                CurrentCounter = Counters[0];
        }
    }

}
