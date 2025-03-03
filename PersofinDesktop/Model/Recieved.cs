using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    internal class Recieved : Indexable
    {
        public DateTime Date { get; set; }

        public RecievedType RecievedType { get; set; }

        public string Description { get; set; } = string.Empty!;
        public decimal Amount { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public ObservableCollection<string> PaymentInfo { get; set; } = new ObservableCollection<string>();

        public BankAccount? RecievedToAccount { get; set; }

        // If it is an income => only
        public IncomeSource? IncomeSource { get; set; }
    }

    public enum RecievedType
    {
        Salary,
        Bonus,
        BusinessIncome,
        Loan,
        LoanRepayment,
        Refund,
        Gift,
        Inheritance,
        InvestmentReturns,
        Other
    }
}
