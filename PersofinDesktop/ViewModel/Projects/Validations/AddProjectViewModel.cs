using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.ViewModel.Projects
{ 
    /// <summary>
    ///  VALIDATIONS
    /// </summary>
    internal partial class AddProjectViewModel : ViewModelBase
    { 
        /// <summary>
        /// Add Validation
        /// </summary>
        /// <returns>Gets if a new prject can be added or not</returns>
        private bool CanAddProject(object? parameter)
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
