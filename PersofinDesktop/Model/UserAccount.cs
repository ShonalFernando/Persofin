using Microsoft.Xaml.Behaviors.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    class UserAccount
    {
        // Identification
        public int ID { get; set; }
        public string UserName { get; set; } = null!;
        public string PasswordHarsh { get; set; } = null!;
    }
}
