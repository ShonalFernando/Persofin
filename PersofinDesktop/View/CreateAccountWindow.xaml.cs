using PersofinDesktop.ViewModel.Authentication;
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

namespace PersofinDesktop.View
{
    /// <summary>
    /// Interaction logic for CreateAccountWindow.xaml
    /// </summary>
    public partial class CreateAccountWindow : Window
    {
        AccountCreator _accountCreator;

        public CreateAccountWindow()
        {
            InitializeComponent();

            /// <summary>
            /// Initializes Data Context and setup for binding
            /// </summary>
            _accountCreator = new AccountCreator();
            DataContext = _accountCreator;
        }

        private void PasswordChanged(object sender, RoutedEventArgs e) => _accountCreator.Password = PasswordInput.Password;
    }
}
