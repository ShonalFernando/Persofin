using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersofinDesktop.ViewModel.Projects
{
    internal partial class ProjectPaymentViewModel : ViewModelBase
    {
        private bool CanEditPayment(Object? parameter)
        {
            if (SelectedPayment is null)
            { return false; }

            return true;
        }

        private bool CanDeletePayment(Object? parameter)
        {
            if (SelectedPayment is null)
            {
                return false;  
            }

            return true;
        }

        private bool DeletePermit()
        {
            var mbDV = MessageBox.Show("Are you show you wanna delete payment?", "Projects | Payments", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (mbDV == MessageBoxResult.Yes)
            {
                return false;
            }

            return true;
        }
    }
}
