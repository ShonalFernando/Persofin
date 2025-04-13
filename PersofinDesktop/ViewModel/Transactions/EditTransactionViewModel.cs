using PersofinDesktop.Command;
using PersofinDesktop.Data.Repositories;
using PersofinDesktop.Data;
using PersofinDesktop.Helper;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersofinDesktop.ViewModel.Transactions
{
    internal class EditTransactionViewModel : ViewModelBase
    {
        private DateTime _dateOfTransaction = DateTime.Today;
        private string _description = string.Empty;
        private decimal _amount;
        private string _category = string.Empty;
        private string _transactionType = "Credit";

        private int EditingTransactionID;

        private readonly TransactionRepository _transactionRepo;
        private readonly Action _closeWindowAction;

        private TransactionRecord _editingTransactionRecord;

        public TransactionRecord EditingTransactionRecord
        {
            get => _editingTransactionRecord;
        }

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
        };


        public ICommand EditTransactionCommand { get; }

        public EditTransactionViewModel(Action closeWindowAction, TransactionRecord transactionRecord)
        {
            EditTransactionCommand = new RelayCommand(async _ => await ExecuteEditTransaction(), CanExecuteEditTransaction);

            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            _transactionRepo = new TransactionRepository(context);
            _editingTransactionRecord = transactionRecord;
            EditingTransactionID = transactionRecord.Id;

            MapBack();

            _closeWindowAction = closeWindowAction;
        }

        private void MapBack()
        {
            DateOfTransaction = _editingTransactionRecord.DateOfRecord;
            Description = _editingTransactionRecord.Description;
            Amount = _editingTransactionRecord.Amount;       
            TransactionType = _editingTransactionRecord.TransactionType;

            UpdateCategories();

            Category = _editingTransactionRecord.Category;
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

        private async Task ExecuteEditTransaction()
        {
            // You can integrate repository logic here to persist this to DB.
            _editingTransactionRecord = new TransactionRecord
            {
                Id = EditingTransactionID,
                DateOfRecord = DateOfTransaction,
                Description = Description,
                Amount = Amount,
                Category = Category,
                TransactionType = TransactionType
            };
            await _transactionRepo.UpdateAsync(_editingTransactionRecord);
            await _transactionRepo.SaveAsync();

            //MessageBox.Show($"[Add] {record.Description}, {record.Amount} ({record.TransactionType}) on {record.DateOfRecord.ToShortDateString()}");
            _closeWindowAction();
        }

        private bool CanExecuteEditTransaction(object? parameter)
        {
            return Amount > 0 && !string.IsNullOrWhiteSpace(Description) && !string.IsNullOrEmpty(TransactionType) && !string.IsNullOrEmpty(Category);
        }
    }
}