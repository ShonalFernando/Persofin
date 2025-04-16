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

        public ProjectPaymentViewModel(int projectId)
        {
            ClearEditCommand = new RelayCommand(_ => ClearFields());//, CanGoToEdit);
            AddCommand = new RelayCommand(_ => ExecuteAdd());//, CanGoToEdit);

            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            _projectPayRepo = new ProjectPaymentRepository(context);
            _projectRepo = new ProjectRepository(context);

            Payment = new ProjectPayment();

            ProjectId = projectId;
            RefreshPayments();
        }


        // Execution Logc
        private async void ExecuteAdd()
        {
            MapToData(false);
            MessageBox.Show($"{Payment.ProjectId}");
            await _projectPayRepo.AddAsync(Payment);
            await _projectPayRepo.SaveAsync();
            RefreshPayments();
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
