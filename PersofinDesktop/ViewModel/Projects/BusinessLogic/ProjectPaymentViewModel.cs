using Microsoft.EntityFrameworkCore;
using PersofinDesktop.Command;
using PersofinDesktop.Data;
using PersofinDesktop.Data.Repositories;
using PersofinDesktop.Helper;
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
        private bool _isEditMode;
        private readonly ProjectPaymentRepository _projectPayRepo;
        private readonly ProjectRepository _projectRepo;
        private int _projectID;

        public ProjectPaymentViewModel(int projectId)
        {
            _payments = null!;
            _payment = null!;

            DateSelected = DateTime.Now;

            ClearEditCommand = new RelayCommand(_ => ClearFields());
            AddCommand = new RelayCommand(_ => ExecuteAdd());
            GoToEditCommand = new RelayCommand(_ => GoToEdit(), CanEditPayment);
            FilterCommand = new RelayCommand(_ => FilterExecute(true));
            UpdateCommand = new RelayCommand(_ => ExecuteUpdate());
            DeleteCommand = new RelayCommand(_ => ExecuteDelete());

            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            _projectPayRepo = new ProjectPaymentRepository(context);
            _projectRepo = new ProjectRepository(context);

            _isEditMode = false;
            ToggleAddEdit();

            Payment = new ProjectPayment();

            ProjectId = _projectID = projectId;
            RefreshPayments();
            ShowAll = true;
        }


        // Execution Logc
        private async void ExecuteAdd()
        {
            MapToData(false);

            await _projectPayRepo.AddAsync(Payment);
            await _projectPayRepo.SaveAsync();

            RefreshPayments();
        }

        private async void ExecuteUpdate()
        {
            MapToData(false);

            var _tempPID = ProjectId;

            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            var _projectPayUpRepo = new ProjectPaymentRepository(context);

            await _projectPayUpRepo.UpdateAsync(Payment);
            await _projectPayUpRepo.SaveAsync();

            _isEditMode = false;

            ToggleAddEdit();
            RefreshPayments();
            ClearFields();

            ProjectId = _tempPID;
        }

        private async void ExecuteDelete()
        {
            if (MessageBox.Show("Are you sure you want to delete this Payment?","Project Payments",MessageBoxButton.YesNo,MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                var _tempPID = ProjectId;

                if (SelectedPayment is not null)
                {
                    MapToData(false);

                    var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
                    var _projectPayDelRepo = new ProjectPaymentRepository(context);

                    await _projectPayDelRepo.DeleteAsync(SelectedPayment);
                    await _projectPayDelRepo.SaveAsync();

                    ProjectId = _tempPID;
                    RefreshPayments();
                } 
            }
        }

        private async void FilterExecute(bool isFromCommand)
        {
            if (ShowAll && isFromCommand)
            {
                ShowAll = false;
            }
                Payments.Clear();
                Payments = new ObservableCollection<ProjectPayment>(
                    (await _projectPayRepo.GetAllAsync())
                    .Where(f => f.PaymentDate.Date == DateSelected.Date)
                    .ToList());
        }

        private void ShowAllExecute()
        {
            if (ShowAll)
            {
                Payments.Clear();
                RefreshPayments();
            }
            else
            {
                FilterExecute(false);
            }
        }

        private void GoToEdit()
        {
            _isEditMode = true;

            ToggleAddEdit();

            if (SelectedPayment is not null)
                Payment = SelectedPayment;

            MapToData(true);
        }

        // Helpers - Not Completed
        private void MapToData(bool isFromModel)
        {
            if (isFromModel)
            {
                Amount = Payment.Amount;
                PaymentDate = Payment.PaymentDate;
                Notes = Payment.Notes;
                ProjectId = Payment.ProjectId;
                PaymentId = Payment.Id;
            }
            else
            {
                Payment.Amount = Amount;
                Payment.PaymentDate = PaymentDate;
                Payment.Notes = Notes;
                Payment.ProjectId = ProjectId;
                Payment.Id = PaymentId;
            }
        }

        // Populators
        private async void RefreshPayments()
        {
            Payments = new ObservableCollection<ProjectPayment>(await _projectRepo.GetPaymentsForProjectAsync(ProjectId));
        }

        // UI Magic
        private void ClearFields()
        {
            Amount = 0;
            PaymentDate = DateTime.Now;
            Notes = string.Empty;
            PaymentId = 0;
            IDFieldEnabled = false;

            _isEditMode = false;
            ToggleAddEdit();
        }

        private void ToggleAddEdit()
        {
            IsAddButtonVisible = System.Windows.Visibility.Collapsed;
            IsEditButtonVisible = System.Windows.Visibility.Collapsed;

            if (_isEditMode)
            {
                IsEditButtonVisible = System.Windows.Visibility.Visible;
            }
            else
            {
                IsAddButtonVisible = System.Windows.Visibility.Visible;
            }
        }
    }
}
