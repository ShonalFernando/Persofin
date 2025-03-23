using iNKORE.UI.WPF.Modern.Controls;
using PersofinDesktop.Command;
using PersofinDesktop.Model;
using PersofinDesktop.Services.Streams;
using PersofinDesktop.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersofinDesktop.ViewModel.Authentication
{
    internal class Authenticator : ViewModelBase
    {
        #region Private Fields and Properties
        /// <summary>
        /// Stores the username of the user.
        /// </summary>
        private string? _username;

        public string? Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Stores the password of the user.
        /// </summary>
        private string? _password;

        public string? Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }
        #endregion

        #region Actions

        /// <summary>
        /// Trigger UI to Close Window
        /// </summary>
        public event Action? ShutdownApplication;
        public event Action? GotoCreateAccountWindow;
        public event Action? JumpToMainShell;

        #endregion

        #region Commands
        /// <summary>
        /// Gets the command to navigate to the account creation page.
        /// </summary>
        public ICommand GotoCreateAccountCommand { get; } = null!;
        public ICommand AuthenticateCommand { get; } = null!;
        public ICommand ExitCommand { get; } = null!;

        #endregion

        #region Constructors & Initializors
        /// <summary>
        /// Constructor
        /// </summary>
        public Authenticator()
        {
            GotoCreateAccountCommand = new RelayCommand(TriggerNavigationToCreateAccountPage);
            ExitCommand = new RelayCommand(TriggerShutdownApplication);
            AuthenticateCommand = new RelayCommand(Authenticate, CanLogin);
        }
        #endregion

        #region Business Logic
        /// <summary>
        /// Trigger UI to Navigate to the Create New User Account Page
        /// </summary>
        private void TriggerNavigationToCreateAccountPage(object? parameter) => GotoCreateAccountWindow?.Invoke();

        /// <summary>
        /// Trigger UI to Navigate to the Create New User Account Page
        /// </summary>
        private void TriggerShutdownApplication(object? parameter) => ShutdownApplication?.Invoke();

        /// <summary>
        /// Navigates to the Create Account Page
        /// </summary>
        private void Authenticate(object? parameter)
        {
            var Users = new UserAccountService().GetAllUserAccounts();
            var User = Users.Find(u => u.UserName.Equals(Username));

            if (User is null)
            {
                MessageBox.Show($"No User Found {Username}");
            }
            else
            {
                if (User.PasswordHarsh != Password)
                {
                    MessageBox.Show("Wrong Password");
                }
                else
                {
                    SessionManager.CurrentUser = User;
                    JumpToMainShell?.Invoke();
                }
            }

            

        }
        #endregion

        #region Validators
        /// <summary>
        /// validate Account on creation
        /// </summary>
        private bool CanLogin(object? parameter)
        {
            //if (Username is null) return false;
            //if (Password is null) return false;

            // Call Other Validator Helpers here

            return true;
        }
        #endregion
    }
}
