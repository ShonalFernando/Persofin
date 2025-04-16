using PersofinDesktop.Command;
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
using System.Windows;

namespace PersofinDesktop.ViewModel.Projects.DataFields
{
    partial class EditProjectViewModel : ViewModelBase
    { 
        private bool SafetyCheckPoint()
        {
            string SafeRequirements = "";

            if (string.IsNullOrEmpty(Requirements))
            {
                SafeRequirements += " - Requirements\n";
            }

            if (string.IsNullOrEmpty(BudgetInfo))
            {
                SafeRequirements += " - Budget Info\n";
            }

            if (string.IsNullOrEmpty(Progress))
            {
                SafeRequirements += " - Progress\n";
            }

            if(!string.IsNullOrEmpty(SafeRequirements))
            {
                var mbSF = MessageBox.Show("One or more Fields are missing!\n" + SafeRequirements + "Proceed?", "Projects", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if(mbSF == MessageBoxResult.Yes)
                {
                    return true;
                }
            }

            return false;
        }
     
        private bool CanUpdateProject(object? parameter)
        {
            if (string.IsNullOrEmpty(Title))
            {
                ValidationMessage = "Title cannot be empty.";
                return false;
            }

            if (string.IsNullOrEmpty(ProjectStatus))
            {
                ValidationMessage = "Please select a project status.";
                return false;
            }

            if (string.IsNullOrEmpty(Category))
            {
                ValidationMessage = "Please select a project category.";
                return false;
            }

            if (TotalBudget < 0)
            {
                ValidationMessage = "Total budget must be a positive number.";
                return false;
            }

            if (DateEnd < DateStart)
            {
                ValidationMessage = "End date cannot be earlier than start date.";
                return false;
            }

            ValidationMessage = ""; // Clear message if all good
            return true;
        }
    }
}
