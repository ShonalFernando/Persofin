using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    internal class DebtOrLoan : Indexable
    {
        public decimal AmmountBorrowed { get; set; }
        public decimal RemainingBalance { get; set; }

        public decimal InterestRate { get; set; }
        public decimal PaymentSchedule { get; set; }

        public string? LenderName { get; set; }
        public ObservableCollection<string> LenderInfo { get; set; } = []; 

        public BankAccount? AttachedBankAccount { get; set; }
    }
}
