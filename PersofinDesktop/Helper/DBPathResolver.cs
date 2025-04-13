using PersofinDesktop.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Helper
{
    // Top-Secure
    internal class DBPathResolver
    {
        public static string ResolveDataBasePath()
        {
            string appDataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "MyFinanceApp");

            Directory.CreateDirectory(appDataPath); // Ensure folder exists

            return Path.Combine(appDataPath, "Persofin", "Data", $"persofinappdata.db");
        }

        public static string ResolveDataDirectoryPath()
        {
            string appDataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "MyFinanceApp");

            Directory.CreateDirectory(appDataPath); // Ensure folder exists

            return Path.Combine(appDataPath, "Persofin", "Data");
        }
    }
}
