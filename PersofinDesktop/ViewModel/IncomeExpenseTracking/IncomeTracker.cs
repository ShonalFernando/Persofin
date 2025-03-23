using PersofinDesktop.Command;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersofinDesktop.ViewModel.IncomeExpenseTracking
{
    class IncomeTracker : ViewModelBase
    {
        private DateTime _date = DateTime.Now;
        private RecievedType _recievedType;
        private string _description = string.Empty;
        private decimal _amount;
        private PaymentMethod _paymentMethod;
        private BankAccount? _recievedToAccount;
        private IncomeSource? _incomeSource;

        public DateTime Date
        {
            get => _date;
            set { _date = value; OnPropertyChanged(); }
        }

        public RecievedType RecievedType
        {
            get => _recievedType;
            set { _recievedType = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get => _description;
            set { _description = value; OnPropertyChanged(); }
        }

        public decimal Amount
        {
            get => _amount;
            set { _amount = value; OnPropertyChanged(); }
        }

        public PaymentMethod PaymentMethod
        {
            get => _paymentMethod;
            set { _paymentMethod = value; OnPropertyChanged(); }
        }

        public ObservableCollection<string> PaymentInfo { get; set; } = new();

        public BankAccount? RecievedToAccount
        {
            get => _recievedToAccount;
            set { _recievedToAccount = value; OnPropertyChanged(); }
        }

        public IncomeSource? IncomeSource
        {
            get => _incomeSource;
            set { _incomeSource = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; }

        public IncomeTracker()
        {
            SaveCommand = new RelayCommand(SaveTransaction);
        }

        private void SaveTransaction(object? parameter)
        {
            // Logic to save transaction
        }
    }
}
