using PersofinDesktop.Data.Repositories;
using PersofinDesktop.Model;
using PersofinDesktop.ViewModel.Transactions;
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

namespace PersofinDesktop.View.Transactions
{
    /// <summary>
    /// Interaction logic for EditTransactionWindow.xaml
    /// </summary>
    public partial class EditTransactionWindow : Window
    {
        public EditTransactionWindow(TransactionRecord transactionRecord)
        {
            InitializeComponent();
            DataContext = new EditTransactionViewModel(Close, transactionRecord);
        }
    }
}
