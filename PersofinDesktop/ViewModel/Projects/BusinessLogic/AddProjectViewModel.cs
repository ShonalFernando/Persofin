using PersofinDesktop.Command;
using PersofinDesktop.Data;
using PersofinDesktop.Data.Repositories;
using PersofinDesktop.Helper;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersofinDesktop.ViewModel.Projects
{
    /// <summary>
    /// Business Logic
    /// </summary>
    internal partial class AddProjectViewModel : ViewModelBase
    {
        // To Perform Repository Actions
        private readonly ProjectRepository _projectRepo;
        private readonly Action _closeWindowAction;

        /// <summary>
        ///  Constructor of Adding Projects View Model
        /// </summary>
        public AddProjectViewModel(Action closeWindowAction)
        {
            // Bind the Command with the logic
            AddProjectCommand = new RelayCommand(_ => AddProject(), CanAddProject);

            // Initialze Repository
            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            _projectRepo = new ProjectRepository(context);

            // Action Passed From the UI to View Model
            _closeWindowAction = closeWindowAction;
        }

        /// <summary>
        /// This will add a new Project
        /// </summary>
        private async void AddProject()
        {
            // Mape User Input to Project Object
            var newProject = new Project()
            {
                BudgetInfo = BudgetInfo,
                DateStart = DateStart,
                DateEnd = DateEnd,
                ProjectStatus = ProjectStatus,
                DateRecorded = DateTime.Now,
                Category = Category,
                Progress = Progress,
                Requirements = Requirements,
                Title = Title,
                TotalBudget = TotalBudget
            };

            // Add to Database
            await _projectRepo.AddAsync(newProject);
            await _projectRepo.SaveAsync();

            _closeWindowAction();
        }
    }
}
