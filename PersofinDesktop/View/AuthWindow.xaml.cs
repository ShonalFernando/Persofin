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
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        Authenticator? _authenticator;

        public AuthWindow()
        {
            InitializeComponent();

            /// <summary>
            /// Initializes Data Context and setup for binding
            /// </summary>
            _authenticator = new Authenticator();
            DataContext = _authenticator;

            _authenticator.ShutdownApplication += _authenticator_ShutdownApplication;
            _authenticator.GotoCreateAccountWindow += _authenticator_GotoCreateAccountWindow;
            _authenticator.JumpToMainShell += _authenticator_JumpToMainShell;
        }

        private void _authenticator_JumpToMainShell() => OpenMainShell();
        private void _authenticator_GotoCreateAccountWindow() => NavigateToCreateAccountWindow();
        private void _authenticator_ShutdownApplication() => Application.Current.Shutdown();
        private void PasswordChanged(object sender, RoutedEventArgs e) => _authenticator.Password = PasswordInput.Password;

        private void NavigateToCreateAccountWindow()
        {
            new CreateAccountWindow().Show();
            Close();
        }

        private void OpenMainShell()
        {
            new ShellWindow().Show();
            Close();
        }
    }
}
