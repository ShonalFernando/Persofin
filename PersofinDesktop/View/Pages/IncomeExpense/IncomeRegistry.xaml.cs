﻿using PersofinDesktop.ViewModel.IncomeExpenseTracking;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersofinDesktop.View.Pages.IncomeExpense
{
    /// <summary>
    /// Interaction logic for IncomeRegistry.xaml
    /// </summary>
    public partial class IncomeRegistry : Page
    {
        IncomeTracker _incomeTracker;

        public IncomeRegistry()
        {
            InitializeComponent();
            _incomeTracker = new IncomeTracker();
            DataContext = _incomeTracker;
        }
    }
}
