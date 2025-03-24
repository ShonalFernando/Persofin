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
    class IncomeSourceTracker : ViewModelBase
    {
        private string _name = string.Empty;
        private IncomeType _incomeType;
        private decimal _expectedAmount;
        private string? _contactPerson;
        private string? _contactEmail;
        private string? _contactPhone;
        private PaymentFrequency _paymentFrequency;
        private string? _notes;
        private BankAccount? _accountAttached;

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        public IncomeType IncomeType
        {
            get => _incomeType;
            set { _incomeType = value; OnPropertyChanged(nameof(IncomeType)); }
        }

        public decimal ExpectedAmount
        {
            get => _expectedAmount;
            set { _expectedAmount = value; OnPropertyChanged(nameof(ExpectedAmount)); }
        }

        public string? ContactPerson
        {
            get => _contactPerson;
            set { _contactPerson = value; OnPropertyChanged(nameof(ContactPerson)); }
        }

        public string? ContactEmail
        {
            get => _contactEmail;
            set { _contactEmail = value; OnPropertyChanged(nameof(ContactEmail)); }
        }

        public string? ContactPhone
        {
            get => _contactPhone;
            set { _contactPhone = value; OnPropertyChanged(nameof(ContactPhone)); }
        }

        public PaymentFrequency PaymentFrequency
        {
            get => _paymentFrequency;
            set { _paymentFrequency = value; OnPropertyChanged(nameof(PaymentFrequency)); }
        }

        public string? Notes
        {
            get => _notes;
            set { _notes = value; OnPropertyChanged(nameof(Notes)); }
        }

        public BankAccount? AccountAttached
        {
            get => _accountAttached;
            set { _accountAttached = value; OnPropertyChanged(nameof(AccountAttached)); }
        }

        public ObservableCollection<IncomeType> IncomeTypes { get; } = new ObservableCollection<IncomeType>(Enum.GetValues<IncomeType>());
        public ObservableCollection<PaymentFrequency> PaymentFrequencies { get; } = new ObservableCollection<PaymentFrequency>(Enum.GetValues<PaymentFrequency>());
        public ObservableCollection<BankAccount> BankAccounts { get; } = new ObservableCollection<BankAccount>();  // Load from DB

        public ICommand SaveCommand { get; }

        public IncomeSourceTracker()
        {
            SaveCommand = new RelayCommand(Save, CanSave);
            LoadBankAccounts();
        }


        private void LoadBankAccounts()
        {
            // Example: Load bank accounts from a service or database
            BankAccounts.Add(new BankAccount { AccountNumber = "12345", NameOnAccount = "Bank A" });
            BankAccounts.Add(new BankAccount { AccountNumber = "67890", NameOnAccount = "Bank B" });
        }

        private bool CanSave(object? parameter) => !string.IsNullOrWhiteSpace(Name) && ExpectedAmount > 0;

        private void Save(object? parameter)
        {
            // Save logic here (e.g., database or API call)
            Console.WriteLine($"Saving Income Source: {Name}, Amount: {ExpectedAmount}");
        }
    }
}
