﻿using PersofinDesktop.Command;
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
        public ICommand GoToPaymentsCommand { get; }
        public ICommand GotoAddProjectCommand { get; }
        public ICommand GotoEditProjectCommand { get; }
        public ICommand DeleteProjectCommand { get; }
        public ICommand FilterProjectsCommand { get; }
        public ICommand GoToResourcesCommand { get; }
        public ICommand GoToTasksCommand { get; }
    }
}
