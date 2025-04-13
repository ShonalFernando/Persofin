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

        private bool CanGoToEdit(object? parameter)
        {
            if (SelectedProject is null)
                return false;

            return true;
        }

        private bool CanAddTransaction()
        {
            return !string.IsNullOrWhiteSpace(NewProject.Title)
                && NewProject.TotalBudget != 0;
        }
    }
}
