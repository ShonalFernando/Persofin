using iNKORE.UI.WPF.Helpers;
using PersofinDesktop.View.Projects;
using PersofinDesktop.View.Transactions;
using PersofinDesktop.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersofinDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void TESTEST_SelectionChanged(iNKORE.UI.WPF.Modern.Controls.NavigationView sender, iNKORE.UI.WPF.Modern.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            if (TESTEST.SelectedItem != null)
            {
                var prop = TESTEST.SelectedItem.GetProperty("Content").ToString();

                if(prop == "Transactions")
                {
                    MainFrame.Content = new TransactionsView();
                }
                else if (prop == "Projects")
                {
                    MainFrame.Content = new ProjectsView();
                }
            }
        }
    }
}