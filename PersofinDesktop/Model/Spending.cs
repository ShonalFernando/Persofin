using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    internal class Spending : Indexable
    {
        public DateTime Date { get; set; }

        public SpendType SpendType { get; set; }

        public string Description { get; set; } = string.Empty!;
        public decimal Amount { get; set; }

        public BankAccount? SpentByAccount { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public ObservableCollection<string> PaymentInfo { get; set; } = new ObservableCollection<string>();
    }

    public enum SpendType
    {
        Personal,
        Utlities,
        OtherTurnover,
        DebtRepayments,
        Savings,
        Insurance,
        Investments,
        Education,
        PersonalDevelopment,
        Donations,
        Gifts,
        Depreciation,
        Other
    }

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        BankTransfer,
        MobilePayment,
        Cryptocurrency,
        Other
    }
}
