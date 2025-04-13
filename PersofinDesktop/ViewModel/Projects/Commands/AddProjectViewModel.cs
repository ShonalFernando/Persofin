using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersofinDesktop.ViewModel.Projects
{
    /// <summary>
    /// Commands
    /// </summary>
    internal partial class AddProjectViewModel : ViewModelBase
    {
        public ICommand AddProjectCommand { get; }
    }
}
