using iNKORE.UI.WPF.Modern.Controls;
using PersofinDesktop.View.Transactions;
using PersofinDesktop.ViewModel.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Page = System.Windows.Controls.Page;

namespace PersofinDesktop.View.Projects
{
    /// <summary>
    /// Interaction logic for ProjectsView.xaml
    /// </summary>
    public partial class ProjectsView : Page
    {
        public ProjectsView()
        {
            InitializeComponent();
            DataContext = new ProjectsViewModel((projectId) =>
            {
                NavigationService?.Navigate(new PaymentsView(projectId));
            });
        }
    }
}
