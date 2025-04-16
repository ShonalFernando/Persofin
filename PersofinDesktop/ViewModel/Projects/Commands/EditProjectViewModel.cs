using PersofinDesktop.Data;
using PersofinDesktop.Data.Repositories;
using PersofinDesktop.Helper;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersofinDesktop.ViewModel.Projects.DataFields
{
    partial class EditProjectViewModel : ViewModelBase
    {
        public ICommand EditProjectCommand { get; }
    }
}
