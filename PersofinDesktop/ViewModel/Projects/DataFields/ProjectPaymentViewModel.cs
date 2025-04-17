using PersofinDesktop.Model;
using PersofinDesktop.Model.ProjectManagement;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersofinDesktop.ViewModel.Projects
{
    internal partial class ProjectPaymentViewModel : ViewModelBase
    {
        private int _projectId;
        public int ProjectId
        {
            get => _projectId;
            set
            {
                _projectId = value;
                OnPropertyChanged();
            }
        }

        private int _paymentId;
        public int PaymentId
        {
            get => _paymentId;
            set
            {
                _paymentId = value;
                OnPropertyChanged();
            }
        }

        private decimal _amount;
        public decimal Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged();
            }
        }

        private DateTime _paymentDate = DateTime.Now;
        public DateTime PaymentDate
        {
            get => _paymentDate;
            set
            {
                _paymentDate = value;
                OnPropertyChanged();
            }
        }

        private string _notes = string.Empty;
        public string Notes
        {
            get => _notes;
            set
            {
                _notes = value;
                OnPropertyChanged();
            }
        }

        private ProjectPayment _payment;
        public ProjectPayment Payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ProjectPayment> _payments;
        public ObservableCollection<ProjectPayment> Payments
        {
            get => _payments;
            set
            {
                _payments = value;
                OnPropertyChanged();
            }
        }

        // Optional: selected Project object, useful for UI dropdown binding
        private ProjectPayment? _selectedPayment;
        public ProjectPayment? SelectedPayment
        {
            get => _selectedPayment;
            set
            {
                _selectedPayment = value;
                OnPropertyChanged();

                // Automatically update foreign key when project selected
                if (_selectedPayment != null)
                    ProjectId = _selectedPayment.ProjectId;
            }
        }
        // For Filters
        private DateTime _dateSelected;
        public DateTime DateSelected
        {
            get => _dateSelected;
            set
            {
                _dateSelected = value;
                OnPropertyChanged();
            }
        }

        private bool _showALl;
        public bool ShowAll
        {
            get => _showALl;
            set
            {
                _showALl = value;
                OnPropertyChanged();
                ShowAllExecute();
            }
        }

        // UI Helper Fields and Properties
        private bool _idFieldEnabled;
        public bool IDFieldEnabled
        {
            get => _idFieldEnabled;
            set
            {
                _idFieldEnabled = value;
                OnPropertyChanged();
            }
        }

        private Visibility _isAddButtonVisible;
        public Visibility IsAddButtonVisible
        {
            get => _isAddButtonVisible;
            set
            {
                _isAddButtonVisible = value;
                OnPropertyChanged();
            }
        }

        private Visibility _isEditButtonVisible;
        public Visibility IsEditButtonVisible
        {
            get => _isEditButtonVisible;
            set
            {
                _isEditButtonVisible = value;
                OnPropertyChanged();
            }
        }
    }
}
