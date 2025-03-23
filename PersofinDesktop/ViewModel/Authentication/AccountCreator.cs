using iNKORE.UI.WPF.Modern.Controls;
using PersofinDesktop.Command;
using PersofinDesktop.Model;
using PersofinDesktop.Services.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace PersofinDesktop.ViewModel.Authentication
{
    class AccountCreator : ViewModelBase
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
        public event Action? GotoLoginWindow;

        #endregion

        #region Commands
        /// <summary>
        /// Gets the command to navigate to the account creation page.
        /// </summary>
        public ICommand GotoLoginCommand { get; } = null!;
        public ICommand CreateAccountCommand { get; } = null!;
        public ICommand ExitCommand { get; } = null!;

        #endregion

        #region Constructors & Initializors
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountCreator()
        {
            GotoLoginCommand = new RelayCommand(TriggerNavigationToLoginWindow);
            ExitCommand = new RelayCommand(TriggerShutdownApplication);
            CreateAccountCommand = new RelayCommand(CreateAccount, CanCreateAccount);
        }
        #endregion

        #region Business Logic
        /// <summary>
        /// Trigger UI to Navigate to the Create New User Account Page
        /// </summary>
        private void TriggerNavigationToLoginWindow(object? parameter) => GotoLoginWindow?.Invoke();

        /// <summary>
        /// Trigger UI to Navigate to the Create New User Account Page
        /// </summary>
        private void TriggerShutdownApplication(object? parameter) => ShutdownApplication?.Invoke();

        /// <summary>
        /// Navigates to the Create Account Page
        /// </summary>
        private void CreateAccount(object? parameter)
        {
            new UserAccountService().AddUserAccount(
                new UserAccount()
                {
                    ID = 0,
                    GUID = Guid.NewGuid(),
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    OwnerID = -1,// Owner is Same
                    PasswordHarsh = "test",
                    UserName = "test"
                });
        }
        #endregion

        #region Validators
        /// <summary>
        /// validate Account on creation
        /// </summary>
        private bool CanCreateAccount(object? parameter)
        {
            //if (Username is null) return false;
            //if (Password is null) return false;

            // Call Other Validator Helpers here

            return true;
        }
        #endregion
    }
}
