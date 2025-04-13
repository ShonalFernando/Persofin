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

        // Filter Data Fields
        private DateTime _dateStartFilter; 
        public DateTime FilterStartDate
        {
            get => _dateStartFilter;
            set
            {
                if (_dateStartFilter != value)
                {
                    _dateStartFilter = value;
                    OnPropertyChanged();
                    UpdateSelectedFilterBasedOnDates();
                }
            }
        }

        private DateTime _dateEndFilter;
        public DateTime FilterEndDate
        {
            get => _dateEndFilter;
            set
            {
                if (_dateEndFilter != value)
                {
                    _dateEndFilter = value;
                    OnPropertyChanged();
                    UpdateSelectedFilterBasedOnDates();
                }
            }
        }

        private string _selectedFilter;
        public string SelectedFilter
        {
            get => _selectedFilter;
            set
            {
                if (_selectedFilter != value)
                {
                    _selectedFilter = value;
                    OnPropertyChanged();
                    SetDateRangeFromcategory();
                }
            }
        }


        // Other
        public ObservableCollection<Project> Projects { get; set; } = new();

        public List<string> Months { get; } = Enumerable.Range(1, 12)
            .Select(i => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i))
            .ToList();


        // For Display Purposes
        private string _projectsCompleted = "00/00";
        public string ProjectsCompleted
        {
            get => _projectsCompleted;
            set
            {
                _projectsCompleted = value;
                OnPropertyChanged();
            }
        }

        private string _projectsPaid = "00/00";
        public string ProjectsPaid
        {
            get => _projectsPaid;
            set
            {
                _projectsPaid = value;
                OnPropertyChanged();
            }
        }

        // Collections
        public ObservableCollection<string> FilterOptions { get; } = new()
        {
            "This Month",
            "This Year",
            "All Time",
            "Custom"
        };
    }
}
