using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.ViewModel.Projects
{
    internal partial class ProjectsViewModel : ViewModelBase
    {
        private Project _newProject = new Project
        {
            DateRecorded = DateTime.Now,
            Category = "Other"
        };

        public Project NewProject
        {
            get => _newProject;
            set { _newProject = value; OnPropertyChanged(); }
        }

        private string _totalExpense = "000.00 LKR";
        public string TotalExpense
        {
            get => _totalExpense;
            set
            {
                _totalExpense = value;
                OnPropertyChanged();
                // Optional: logic when selection changes
            }
        }

        private string _totalIncome = "000.00 LKR";
        public string TotalIncome
        {
            get => _totalIncome;
            set
            {
                _totalIncome = value;
                OnPropertyChanged();
                // Optional: logic when selection changes
            }
        }

        private Project? _selectedProject;
        public Project? SelectedProject
        {
            get => _selectedProject;
            set
            {
                _selectedProject = value;
                OnPropertyChanged();
                // Optional: logic when selection changes
            }
        }

        private int _selectedYear;
        public int SelectedYear
        {
            get => _selectedYear;
            set
            {
                _selectedYear = value;
                OnPropertyChanged();
                FilterTransactionsAsync(); // Filter on change
            }
        }

        private string _selectedMonth;
        public string SelectedMonth
        {
            get => _selectedMonth;
            set
            {
                if (_selectedMonth != value)
                {
                    _selectedMonth = value;
                    OnPropertyChanged();

                    if (value != "Whole Year")
                    {
                        _selectedMonthIndex = DateTime.ParseExact(value, "MMMM", CultureInfo.InvariantCulture).Month;
                    }
                    else
                    {
                        _selectedMonthIndex = -1;
                    }
                    FilterTransactionsAsync(); // or whatever logic
                }
            }
        }

        private int _selectedMonthIndex;
        public int SelectedMonthIndex
        {
            get => _selectedMonthIndex;
            set
            {
                if (_selectedMonthIndex != value)
                {
                    _selectedMonthIndex = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _showAllProjects;
        public bool ShowAllProjects
        {
            get => _showAllProjects;
            set
            {
                if (_showAllProjects != value)
                {
                    _showAllProjects = value;
                    OnPropertyChanged();

                    // Refilter when toggled
                    FilterTransactionsAsync();
                }
            }
        }

        private List<int> _years;  // = Enumerable.Range(2025, _maxYear).ToList();
        public List<int> Years
        {
            get => _years;
            set
            {
                if (_years != value)
                {
                    _years = value;
                    OnPropertyChanged();
                }
            }
        }

        // Other
        public ObservableCollection<Project> Projects { get; set; } = new();

        public List<string> Months { get; } = Enumerable.Range(1, 12)
            .Select(i => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i))
            .ToList();

    }
}
