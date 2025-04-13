using PersofinDesktop.Command;
using PersofinDesktop.Data.Repositories;
using PersofinDesktop.Data;
using PersofinDesktop.Helper;
using PersofinDesktop.Model;
using PersofinDesktop.View.Transactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using PersofinDesktop.View.Projects;

namespace PersofinDesktop.ViewModel.Projects
{
    internal partial class ProjectsViewModel : ViewModelBase
    {
        private readonly ProjectRepository _projectRepo;

        public ProjectsViewModel()
        {
            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            _projectRepo = new ProjectRepository(context);

            //AddTransactionCommand = new RelayCommand(async _ => await AddTransactionAsync(), _ => CanAddTransaction());
            //LoadTransactionsCommand = new RelayCommand(async _ => await LoadTransactionsAsync());

            GotoAddProjectCommand = new RelayCommand(_ => GotoAuxTransactionWIndow(false));
            GotoEditProjectCommand = new RelayCommand(_ => GotoAuxTransactionWIndow(true), CanGoToEdit);
            DeleteProjectCommand = new RelayCommand(async _ => await DeleteTransaction(), CanGoToEdit);
           
            _ = LoadTransactionsAsync(); // Auto-load on startup

            ShowAllProjects = false;
            FetchYearRange();
            SelectedMonth = DateTime.Now.ToString("MMMM");
            SelectedYear = DateTime.Now.Year;
            FilterTransactionsAsync();

            // Refactor later
            Months.Add("Whole Year");

        }

        private async void FetchYearRange()
        {
            var AllTransactions = await _projectRepo.GetAllAsync();
            if (AllTransactions.Count() > 0)
            {
                var min = AllTransactions.Min(t => t.DateRecorded.Year);
                var max = AllTransactions.Max(t => t.DateRecorded.Year);

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
            if (!isEdit)
            {
                new AddProjectWindow().ShowDialog();
            }
            else
            {
                if (SelectedProject is not null)
                    new EditProjectWindow(SelectedProject).ShowDialog();
            }

            FetchYearRange();
            if (!ShowAllProjects)
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
            if (SelectedProject is not null)
            {
                var deleteVerifier = MessageBox.Show("Are you sure you want to delete this entity?", "Transactions", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (deleteVerifier == MessageBoxResult.Yes)
                {
                    await _projectRepo.DeleteAsync(SelectedProject);
                    await _projectRepo.SaveAsync();

                    _ = LoadTransactionsAsync();
                    FetchYearRange();
                    if (!ShowAllProjects)
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

            var filtered = new List<Project>();
            var allTransaction = await _projectRepo.GetAllAsync();

            foreach (var record in allTransaction)
            {
                if (!ShowAllProjects)
                {

                    if (SelectedMonthIndex != -1)
                    {
                        Debug.Write($"{record.DateRecorded} | {record.DateRecorded.Year} | {record.DateRecorded.Month} | Comparing | {SelectedYear}");

                        // No month selected then all months
                        if (record.DateRecorded.Year == SelectedYear && record.DateRecorded.Month == SelectedMonthIndex)
                        {
                            Debug.WriteLine($"{record.DateRecorded.Year} vs {SelectedYear}");
                            filtered.Add(record);
                        }
                        else if (record.DateRecorded.Year == SelectedYear && SelectedMonthIndex == 0)
                        {
                            filtered.Add(record);
                        }

                        Projects.Clear();
                        foreach (var item in filtered)
                        {
                            Projects.Add(item);
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
            var income = Projects
                .Where(t => t.ProjectStatus.Equals("Completed", StringComparison.OrdinalIgnoreCase))
                .Count();

            var expense = Projects
                .Where(t => t.Category.Equals("OnProgress", StringComparison.OrdinalIgnoreCase))
                .Count();

            TotalIncome = $"{income:N2} LKR";
            TotalExpense = $"{expense:N2} LKR";
        }

        private async Task LoadTransactionsAsync()
        {
            Projects.Clear();

            //var items = await _projectRepo.GetAllAsync();
            //foreach (var item in items)
            //    Transactions.Add(item as Project);

            var context2 = new AppDbContext(DBPathResolver.ResolveDataBasePath());

            var items = await (new ProjectRepository(context2)).GetAllAsync();
            foreach (var item in items)
                Projects.Add(item as Project);

            FetchSumarry();
        }
    }
}