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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.Xml;

namespace PersofinDesktop.ViewModel.Projects
{
    internal partial class ProjectsViewModel : ViewModelBase
    {
        private readonly ProjectRepository _projectRepo;

        public ProjectsViewModel(Action<int> navigateAction)
        {
            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            _projectRepo = new ProjectRepository(context);

            //AddTransactionCommand = new RelayCommand(async _ => await AddTransactionAsync(), _ => CanAddTransaction());
            //LoadTransactionsCommand = new RelayCommand(async _ => await LoadTransactionsAsync());

            GoToPaymentsCommand = new RelayCommand(_ => navigateAction(SelectedProject.Id), CanGoToEdit);
            GotoAddProjectCommand = new RelayCommand(_ => GotoAuxTransactionWIndow(false));
            GotoEditProjectCommand = new RelayCommand(_ => GotoAuxTransactionWIndow(true), CanGoToEdit);
            DeleteProjectCommand = new RelayCommand(async _ => await DeleteTransaction(), CanGoToEdit);
            FilterProjectsCommand = new RelayCommand(_ => FilterFromRange());
            _ = LoadTransactionsAsync(); // Auto-load on startup

            ShowAllProjects = false;

            // Refactor later
            Months.Add("Whole Year");

            FilterStartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            FilterEndDate = FilterStartDate.AddMonths(1).AddDays(-1);

            FetchSumarry();
            //FilterTransactionsAsync();
        }


        private void SetDateRangeFromcategory()
        {
            DateTime currentDate = DateTime.Now;

            // Reverse Assignment
            if (SelectedFilter == "This Year")
            {
                FilterStartDate = new DateTime(currentDate.Year, 1, 1);
                FilterEndDate = new DateTime(currentDate.Year, 12, 31);
            }
            else if (SelectedFilter == "This Month")
            {
                FilterStartDate = new DateTime(currentDate.Year, currentDate.Month, 1);
                FilterEndDate = FilterStartDate.AddMonths(1).AddDays(-1);
            }
            else if (SelectedFilter == "All Time")
            {
                // All Projects
                FilterStartDate = DateTime.MinValue;
                FilterEndDate = DateTime.MaxValue;
                ShowAllProjects = true;
            }
        }

        private async void FilterFromRange()
        {
            DateTime currentDate = DateTime.Now;
            ShowAllProjects = false;

            if (FilterStartDate <= FilterEndDate)
            {
                // Reverse Assignment
                SetDateRangeFromcategory();
            }
            else
            {
                var mbDateRangeError = MessageBox.Show("The Start Date should be before the End Date", "Projects", MessageBoxButton.OK, MessageBoxImage.Error);
                if (mbDateRangeError == MessageBoxResult.OK)
                {
                    SelectedFilter = "This Month";

                    FilterStartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    FilterEndDate = FilterStartDate.AddMonths(1).AddDays(-1);
                }
            }

                // Actual Filter
                var allProjects = await _projectRepo.GetAllAsync() as List<Project>;

            if (allProjects != null)
            {
                if (!ShowAllProjects)
                {
                    var projectsFullyInRange = allProjects
                        .Where(p => p.DateStart >= FilterStartDate && p.DateEnd <= FilterEndDate)
                        .ToList();

                    Projects.Clear();
                    foreach (var project in projectsFullyInRange)
                    {
                        Projects.Add(project);
                    }
                }
                else
                {
                    Projects.Clear();
                    foreach (var project in allProjects)
                    {
                        Projects.Add(project);
                    }
                }
            }
            else
            {
                // Handle the null case, maybe log or inform the user
                Debug.WriteLine("Project list could not be retrieved or is empty.");
            }
        }

        private void UpdateSelectedFilterBasedOnDates()
        {
            var currentDate = DateTime.Now;

            var monthStart = new DateTime(currentDate.Year, currentDate.Month, 1);
            var monthEnd = monthStart.AddMonths(1).AddDays(-1);

            var yearStart = new DateTime(currentDate.Year, 1, 1);
            var yearEnd = new DateTime(currentDate.Year, 12, 31);

                if (FilterStartDate.Date == monthStart.Date && FilterEndDate.Date == monthEnd.Date)
                {
                    SelectedFilter = "This Month";
                }
                else if (FilterStartDate.Date == yearStart.Date && FilterEndDate.Date == yearEnd.Date)
                {
                    SelectedFilter = "This Year";
                }
                else
                {
                    SelectedFilter = "Custom";
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
            if (!ShowAllProjects)
            {
                FilterFromRange();
            }
            else
            {
                FilterFromRange();
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

                    if (!ShowAllProjects)
                    {
                        FilterFromRange();
                    }
                    else
                    {
                        FilterFromRange();
                    }
                }
            }
        }


        private void FetchSumarry()
        {
            // MessageBox.Show(Projects.Count.ToString());
            var completeCount = Projects.Count(p =>
                string.Equals(p.ProjectStatus, "Complete", StringComparison.OrdinalIgnoreCase));

            var submittedUnpaid = Projects.Count(p =>
                string.Equals(p.ProjectStatus, "Submitted Unpaid", StringComparison.OrdinalIgnoreCase));

            var onProgressCount = Projects.Count(p =>
                string.Equals(p.ProjectStatus, "OnProgress", StringComparison.OrdinalIgnoreCase));

            var paidCount = Projects.Count(p =>
                string.Equals(p.ProjectStatus, "Complete", StringComparison.OrdinalIgnoreCase));

            Debug.WriteLine($"Complete: {completeCount}, OnProgress: {onProgressCount}");

            ProjectsPaid = $"{completeCount}/{completeCount + onProgressCount + submittedUnpaid}";
            ProjectsCompleted = $"{completeCount + submittedUnpaid}/{completeCount + onProgressCount + submittedUnpaid}";
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
        }
    }
}