using PersofinDesktop.Model;
using PersofinDesktop.ViewModel.Projects.DataFields;
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
using System.Windows.Shapes;

namespace PersofinDesktop.View.Projects
{
    /// <summary>
    /// Interaction logic for EditProjectWindow.xaml
    /// </summary>
    public partial class EditProjectWindow : Window
    {
        public EditProjectWindow(Project project)
        {
            InitializeComponent();
            DataContext = new EditProjectViewModel(Close,project);
        }
    }
}
