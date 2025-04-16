using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersofinDesktop.ViewModel.Projects
{
    internal partial class ProjectPaymentViewModel : ViewModelBase
    {
        public ICommand ClearEditCommand { get; }
        public ICommand AddCommand { get; }
    }
}
