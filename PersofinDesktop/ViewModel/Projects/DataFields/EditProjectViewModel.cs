using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.ViewModel.Projects.DataFields
{
    partial class EditProjectViewModel : ViewModelBase
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dateRecorded = DateTime.Now;
        public DateTime DateRecored
        {
            get => _dateRecorded;
            set
            {
                _dateRecorded = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dateStart = DateTime.Now;
        public DateTime DateStart
        {
            get => _dateStart;
            set
            {
                _dateStart = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dateEnd = DateTime.Now;
        public DateTime DateEnd
        {
            get => _dateEnd;
            set
            {
                _dateEnd = value;
                OnPropertyChanged();
            }
        }

        private decimal _totalBudget;
        public decimal TotalBudget
        {
            get => _totalBudget;
            set
            {
                _totalBudget = value;
                OnPropertyChanged();
            }
        }

        private string _title = string.Empty;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private string _budgetInfo = string.Empty;
        public string BudgetInfo
        {
            get => _budgetInfo;
            set
            {
                _budgetInfo = value;
                OnPropertyChanged();
            }
        }

        private string __projectStatus = string.Empty;
        public string ProjectStatus
        {
            get => __projectStatus;
            set
            {
                __projectStatus = value;
                OnPropertyChanged();
            }
        }

        private string _category = string.Empty;
        public string Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged();
            }
        }

        private string _requirements = string.Empty;
        public string Requirements
        {
            get => _requirements;
            set
            {
                _requirements = value;
                OnPropertyChanged();
            }
        }

        private string _progress = string.Empty;
        public string Progress
        {
            get => _progress;
            set
            {
                _progress = value;
                OnPropertyChanged();
            }
        }

        // The current editing Project
        private Project _editableProject;
        public Project EditableProject
        {
            get => _editableProject;
            set
            {
                _editableProject = value;
                OnPropertyChanged();
            }
        }

        // For UI Purposes
        private string _validationMessage = "";
        public string ValidationMessage
        {
            get => _validationMessage;
            set
            {
                _validationMessage = value;
                OnPropertyChanged();
            }
        }

        // Lists
        public ObservableCollection<string> Categories { get; } = new()
        {
            "Desktop Application Development",
            "Web Application Development",
            "Static Application Development",
            "Digital Marketing",
            "UIUX Development",
            "Code Refactoring",
            "Component Development",
            "Sofware Design Only",
            "Generic Report",
            "Research",
            "Academic Final Year Package",
            "Data Collection",
            "Machine Learning",
            "Analysis",
            "Other"
        };

        public ObservableCollection<string> ProjectStatuses { get; } = new()
        {
            "Waiting", "OnProgress","Cancelled", "Submitted Unpaid","Complete"
        };
    }
}
