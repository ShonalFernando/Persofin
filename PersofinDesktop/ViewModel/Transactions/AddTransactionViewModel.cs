using PersofinDesktop.Command;
using PersofinDesktop.Data;
using PersofinDesktop.Data.Repositories;
using PersofinDesktop.Helper;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersofinDesktop.ViewModel.Transactions
{
    internal class AddTransactionViewModel : ViewModelBase
    {
        private DateTime _dateOfTransaction = DateTime.Today;
        private string _description = string.Empty;
        private decimal _amount;
        private string _category = string.Empty;
        private string _transactionType = "Credit";

        private readonly TransactionRepository _transactionRepo;
        private readonly Action _closeWindowAction;

        public DateTime DateOfTransaction
        {
            get => _dateOfTransaction;
            set
            {
                if (_dateOfTransaction != value)
                {
                    _dateOfTransaction = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged();
                }
            }
        }

        public decimal Amount
        {
            get => _amount;
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Category
        {
            get => _category;
            set
            {
                if (_category != value)
                {
                    _category = value;
                    OnPropertyChanged();
                }
            }
        }

        public string TransactionType
        {
            get => _transactionType;
            set
            {
                if (_transactionType != value)
                {
                    _transactionType = value;
                    OnPropertyChanged();

                    UpdateCategories();
                }
            }
        }

        private readonly Dictionary<string, List<string>> _categoryMapping = new()
        {
            { "Credit", new() { "Salary", "Bonus", "Refund", "Other" } },
            { "Debit", new() { "Food", "Transport", "Bills", "Shopping", "Other" } }
        };

        public ObservableCollection<string> Categories { get; } = new();

        public ObservableCollection<string> TransactionTypes { get; } = new()
        {
            "Credit", "Debit"
        }
;
        public ICommand AddTransactionCommand { get; }

        public AddTransactionViewModel(Action closeWindowAction)
        {
            AddTransactionCommand = new RelayCommand(async _ => await ExecuteAddTransaction(), CanExecuteAddTransaction);

            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            _transactionRepo = new TransactionRepository(context);

            _closeWindowAction = closeWindowAction;

            // Initialization
            TransactionType = "Credit";
            UpdateCategories();
        }

        private void UpdateCategories()
        {
            Categories.Clear();

            if (!string.IsNullOrEmpty(TransactionType) &&
                _categoryMapping.ContainsKey(TransactionType))
            {
                foreach (var category in _categoryMapping[TransactionType])
                {
                    Categories.Add(category);
                }
            }
        }


        private async Task ExecuteAddTransaction()
        {
            // You can integrate repository logic here to persist this to DB.
            var record = new TransactionRecord
            {
                DateOfRecord = DateOfTransaction,
                Description = Description,
                Amount = Amount,
                Category = Category,
                TransactionType = TransactionType
            };

            if(DateOfTransaction > DateTime.Now)
            {
                var MB_vaildateUpcomingDate = MessageBox.Show("Are you sure you want to add a transaction for an upcoming date?", "Transactions", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if(MB_vaildateUpcomingDate == MessageBoxResult.OK)
                {
                    await _transactionRepo.AddAsync(record);
                    await _transactionRepo.SaveAsync();
                }
            }
            else
            {
                await _transactionRepo.AddAsync(record);
                await _transactionRepo.SaveAsync();
            }



            //MessageBox.Show($"[Add] {record.Description}, {record.Amount} ({record.TransactionType}) on {record.DateOfRecord.ToShortDateString()}");
            _closeWindowAction();
        }

        private bool CanExecuteAddTransaction(object? parameter)
        {
            return Amount > 0 && !string.IsNullOrWhiteSpace(Description) && !string.IsNullOrEmpty(TransactionType) && !string.IsNullOrEmpty(Category);
        }
    }
}
