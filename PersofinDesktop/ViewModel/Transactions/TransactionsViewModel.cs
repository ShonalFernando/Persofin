using PersofinDesktop.Command;
using PersofinDesktop.Data.Repositories;
using PersofinDesktop.Data;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PersofinDesktop.Helper;
using PersofinDesktop.View.Transactions;
using System.Diagnostics;
using System.Windows;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace PersofinDesktop.ViewModel.Transactions
{
    internal class TransactionsViewModel : ViewModelBase
    {
        private readonly TransactionRepository _transactionRepo;

        public ObservableCollection<TransactionRecord> Transactions { get; set; } = new();

        private TransactionRecord _newTransaction = new TransactionRecord
        {
            DateOfRecord = DateTime.Now,
            TransactionType = "Credit"
        };

        public TransactionRecord NewTransaction
        {
            get => _newTransaction;
            set { _newTransaction = value; OnPropertyChanged(); }
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

        private TransactionRecord? _selectedTransaction;
        public TransactionRecord? SelectedTransaction
        {
            get => _selectedTransaction;
            set
            {
                _selectedTransaction = value;
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

                    if(value != "Whole Year")
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

        private bool _showAllTransactions;
        public bool ShowAllTransactions
        {
            get => _showAllTransactions;
            set
            {
                if (_showAllTransactions != value)
                {
                    _showAllTransactions = value;
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

        public List<string> Months { get; } = Enumerable.Range(1, 12)
            .Select(i => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i))
            .ToList();


        public ICommand GotoAddTransactionCommand { get; }
        public ICommand GotoEditTransactionCommand { get; }
        public ICommand DeleteTransactionCommand { get; }

        public TransactionsViewModel()
        {
            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            _transactionRepo = new TransactionRepository(context);

            //AddTransactionCommand = new RelayCommand(async _ => await AddTransactionAsync(), _ => CanAddTransaction());
            //LoadTransactionsCommand = new RelayCommand(async _ => await LoadTransactionsAsync());

            GotoAddTransactionCommand = new RelayCommand(_ => GotoAuxTransactionWIndow(false));
            GotoEditTransactionCommand = new RelayCommand(_ => GotoAuxTransactionWIndow(true),CanGoToEdit);
            DeleteTransactionCommand = new RelayCommand(async _ => await DeleteTransaction(), CanGoToEdit);
            _ = LoadTransactionsAsync(); // Auto-load on startup

            ShowAllTransactions = false;
            FetchYearRange();
            SelectedMonth = DateTime.Now.ToString("MMMM");
            SelectedYear = DateTime.Now.Year;
            FilterTransactionsAsync();

            // Refactor later
            Months.Add("Whole Year");

        }

        private async void FetchYearRange()
        {
            var AllTransactions = await _transactionRepo.GetAllAsync();
            if (AllTransactions.Count() > 0)
            {
                var min = AllTransactions.Min(t => t.DateOfRecord.Year);
                var max = AllTransactions.Max(t => t.DateOfRecord.Year);

                if (SelectedYear < min)
                {
                    SelectedYear++;
                }
                else if (SelectedYear > max)
                {
                    SelectedYear--;
                }

                if (max == min)
                {
                    Years = new List<int>() { min };
                }
                else
                {
                    Years = Enumerable.Range(min, max - (min - 1)).ToList();
                } 
            }
        }

        private void GotoAuxTransactionWIndow(bool isEdit)
        {
            if(!isEdit)
            {
                new AddTransactionWindow().ShowDialog();
            }
            else
            {
                if(SelectedTransaction is not null)
                    new EditTransactionWindow(SelectedTransaction).ShowDialog();
            }

            FetchYearRange();
            if (!ShowAllTransactions)
            {
                FilterTransactionsAsync();
            }
            else
            {
                _ = LoadTransactionsAsync();
            }
        }

        private async Task DeleteTransaction()
        {
            if (SelectedTransaction is not null)
            {
                var deleteVerifier = MessageBox.Show("Are you sure you want to delete this entity?", "Transactions", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (deleteVerifier == MessageBoxResult.Yes)
                {
                    await _transactionRepo.DeleteAsync(SelectedTransaction);
                    await _transactionRepo.SaveAsync();

                    _ = LoadTransactionsAsync();
                    FetchYearRange();
                    if (!ShowAllTransactions)
                    {
                        FilterTransactionsAsync();
                    }
                    else
                    {
                        _ = LoadTransactionsAsync();
                    }
                }
            }
        }

        private async void FilterTransactionsAsync()
        {
            await LoadTransactionsAsync();

            var filtered = new List<TransactionRecord>();
            var allTransaction = await _transactionRepo.GetAllAsync();

            foreach (var record in allTransaction)
            {
                if (!ShowAllTransactions)
                {

                    if (SelectedMonthIndex != -1)
                    {
                        Debug.Write($"{record.DateOfRecord} | {record.DateOfRecord.Year} | {record.DateOfRecord.Month} | Comparing | {SelectedYear}");

                        // No month selected then all months
                        if (record.DateOfRecord.Year == SelectedYear && record.DateOfRecord.Month == SelectedMonthIndex)
                        {
                            Debug.WriteLine($"{record.DateOfRecord.Year} vs {SelectedYear}");
                            filtered.Add(record);
                        }
                        else if (record.DateOfRecord.Year == SelectedYear && SelectedMonthIndex == 0)
                        {
                            filtered.Add(record);
                        }

                        Transactions.Clear();
                        foreach (var item in filtered)
                        {
                            Transactions.Add(item);
                        } 
                    }
                    else
                    {
                        filtered.Add(record);
                    }
                }
                else
                {
                    await LoadTransactionsAsync();
                }
            }

            FetchSumarry(); // recalculate income/expense
        }

        private void FetchSumarry()
        {
            var income = Transactions
                .Where(t => t.TransactionType.Equals("Credit", StringComparison.OrdinalIgnoreCase))
                .Sum(t => t.Amount);

            var expense = Transactions
                .Where(t => t.TransactionType.Equals("Debit", StringComparison.OrdinalIgnoreCase))
                .Sum(t => t.Amount);

            TotalIncome = $"{income:N2} LKR";
            TotalExpense = $"{expense:N2} LKR";
        }

        private bool CanGoToEdit(object? parameter)
        {
            if (SelectedTransaction is null)
                return false;

            return true;
        }

        private async Task LoadTransactionsAsync()
        {
            Transactions.Clear();

            //var items = await _transactionRepo.GetAllAsync();
            //foreach (var item in items)
            //    Transactions.Add(item as TransactionRecord);

            var context2 = new AppDbContext(DBPathResolver.ResolveDataBasePath());

            var items = await (new TransactionRepository(context2)).GetAllAsync();
            foreach (var item in items)
                Transactions.Add(item as TransactionRecord);

            FetchSumarry();
        }

        private async Task AddTransactionAsync()
        {
            NewTransaction = new TransactionRecord
            {
                DateOfRecord = DateTime.Now,
                TransactionType = "Credit",
                Amount= 2500,
                Category = "Miscellaneous",
                Description = "Test",
            };            
            
            await _transactionRepo.AddAsync(NewTransaction);
            await _transactionRepo.SaveAsync();
            await LoadTransactionsAsync(); // refresh list

        }

        private bool CanAddTransaction()
        {
            return !string.IsNullOrWhiteSpace(NewTransaction.Description)
                && NewTransaction.Amount != 0;
        }
    }
}
