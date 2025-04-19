using PersofinDesktop.Model.ProjectManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersofinDesktop.ViewModel.Projects.BusinessLogic
{
    class ProjectTaskViewModel:ViewModelBase
    {
        private List<ProjectTask> _myTasks;
        public List<ProjectTask> MyTasks
        {
            get => _myTasks;
            set { _myTasks = value; OnPropertyChanged(); }
        }

        private DateTime _projectStart;
        public DateTime ProjectStart
        {
            get => _projectStart;
            set { _projectStart = value; OnPropertyChanged(); }
        }

        private DateTime _projectEnd;
        public DateTime ProjectEnd
        {
            get => _projectEnd;
            set { _projectEnd = value; OnPropertyChanged(); }
        }

        private ProjectTask _selectedTask;
        public ProjectTask SelectedTask
        {
            get => _selectedTask;
            set { _selectedTask = value; OnPropertyChanged(); MessageBox.Show($"{SelectedTask.Title}"); }
        }

        public ProjectTaskViewModel()
        {
            // Dummy data
            ProjectStart = DateTime.Today;
            ProjectEnd = DateTime.Today.AddDays(7); // 8-day span

            MyTasks = new List<ProjectTask>
        {
            new ProjectTask { Title = "Design", StartDate = ProjectStart, DueDate = ProjectStart.AddDays(2), IsCompleted = true },
            new ProjectTask { Title = "Development", StartDate = ProjectStart.AddDays(1), DueDate = ProjectStart.AddDays(5) },
            new ProjectTask { Title = "Testing", StartDate = ProjectStart.AddDays(5), DueDate = ProjectEnd },
            new ProjectTask { Title = "Deployment", StartDate = ProjectEnd, DueDate = ProjectEnd, IsMilestone = true }
        };
        }
    }
}
