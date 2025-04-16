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

namespace PersofinDesktop.ViewModel.Projects.DataFields
{
    partial class EditProjectViewModel : ViewModelBase
    {
        // To Perform Repository Actions
        private readonly ProjectRepository _projectRepo;
        private readonly Action _closeWindowAction;

        public EditProjectViewModel(Action closeWindowAction, Project _projectToEdit)
        {
            // Initialze Repository
            var context = new AppDbContext(DBPathResolver.ResolveDataBasePath());
            _projectRepo = new ProjectRepository(context);

            // Assignment of Data as Initialization
            _editableProject = EditableProject = _projectToEdit;

            // Initialize Commands
            EditProjectCommand = new RelayCommand(_ => UpdateExecuteProject(), CanUpdateProject);

            // Action Passed From the UI to View Model
            _closeWindowAction = closeWindowAction;

            // Inital Assignment of Data Fields from Model
            MapToData(true);
        }

        private async void UpdateExecuteProject()
        {
            MapToData(false);

            if (SafetyCheckPoint())
            {
                await _projectRepo.UpdateAsync(EditableProject);
                await _projectRepo.SaveAsync();

                _closeWindowAction();
            }
        }


        private void MapToData(bool isFromModel)
        {
            if(isFromModel)
            {
                Id = EditableProject.Id;
                DateRecored = EditableProject.DateRecorded;
                DateStart = EditableProject.DateStart;
                DateEnd = EditableProject.DateEnd;
                TotalBudget = EditableProject.TotalBudget;
                Title = EditableProject.Title;
                BudgetInfo = EditableProject.BudgetInfo;
                Requirements = EditableProject.Requirements;
                Progress = EditableProject.Progress;
                ProjectStatus = EditableProject.ProjectStatus;
                Category = EditableProject.Category;
            }
            else
            {
                EditableProject.Id = Id;
                EditableProject.DateRecorded = DateRecored;
                EditableProject.DateStart = DateStart;
                EditableProject.DateEnd = DateEnd;
                EditableProject.TotalBudget = TotalBudget;
                EditableProject.Title = Title;
                EditableProject.BudgetInfo = BudgetInfo;
                EditableProject.Requirements = Requirements;
                EditableProject.Progress = Progress;
                EditableProject.ProjectStatus = ProjectStatus;
                EditableProject.Category = Category;
            }
        }
    }
}
