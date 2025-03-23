using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Session
{
    internal static class SessionManager
    {
        public static UserAccount? CurrentUser { get; set; }
    }
}
