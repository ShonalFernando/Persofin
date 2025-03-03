using Microsoft.Xaml.Behaviors.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    /// <summary>
    /// Represents a user account with credentials.
    /// Different user Accounts are used to access the same data as 
    /// this application is a Single User Application!
    /// </summary>
    internal class UserAccount : Indexable
    {
        /// <summary>
        /// Gets or sets the username of the account.
        /// </summary>
        [Display(Name = "Username")]
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the hashed password of the account.
        /// </summary>
        [Display(Name = "Password Hash")]
        public string PasswordHarsh { get; set; } = null!;
    }
}
