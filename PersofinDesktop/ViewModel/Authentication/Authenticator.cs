using PersofinDesktop.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersofinDesktop.ViewModel.Authentication
{
    /// <summary>
    /// Handles the Authentication of the Users and other interaction
    /// </summary>

    class Authenticator : ViewModelBase
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

        #region Commands
        /// <summary>
        /// Gets the command to navigate to the account creation page.
        /// </summary>
        public ICommand GotoCreateAccountCommand { get; } = null!;

        /// <summary>
        /// Gets the command to navigate to the account creation page.
        /// </summary>
        public ICommand AuthenticateCommand { get; } = null!;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public Authenticator()
        {
            GotoCreateAccountCommand = new RelayCommand(CreateAccountNavigate);
            AuthenticateCommand = new RelayCommand(Authenticate);
        }

        /// <summary>
        /// Navigates to the Create Account Page
        /// </summary>
        private void CreateAccountNavigate(object? parameter)
        {

        }

        /// <summary>
        /// Authenticate the User and performs navigation
        /// </summary>
        private void Authenticate(object? parameter)
        {

        }
    }
}
