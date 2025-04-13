using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersofinDesktop.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private NavigationItem _selectedMenuItem;
        public NavigationItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set
            {
                _selectedMenuItem = value;
                OnPropertyChanged();
                MessageBox.Show(_selectedMenuItem.Title);
            }
        }
    }

    public class NavigationItem
    {
        public string Title { get; set; }
        public string ViewKey { get; set; }
    }
}
