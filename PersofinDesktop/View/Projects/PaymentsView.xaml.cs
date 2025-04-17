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

namespace PersofinDesktop.View.Projects
{
    /// <summary>
    /// Interaction logic for PaymentsView.xaml
    /// </summary>
    public partial class PaymentsView : Page
    {
        public PaymentsView(int projectId)
        {
            InitializeComponent();
            DataContext = new ProjectPaymentViewModel(projectId);
        }

    }
}
