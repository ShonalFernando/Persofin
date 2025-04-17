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
        public ICommand GoToEditCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand FilterCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }
    }
}
