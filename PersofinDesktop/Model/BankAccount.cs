using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    public class BankAccount : Indexable
    {
        public string Bank { get; set; } = null!;
        public string Branch { get; set; } = null!;

        public string NameOnAccount { get; set; } = null!;        
        public AccountType AccountType { get; set; }
        public string AccountNumber { get; set; } = null!;

        public string CardNumberEnc { get; set; } = null!;
        public string NameOnCard { get; set; } = null!;
        public int CardExpiryMonth { get; set; }
        public int CardExpiryYear { get; set; }
        public int CardSecurityCode { get; set; }

        public string? JointAccountMemberName { get; set; }
        public string? JointAccountMemberNIC { get; set; }

        public string? NameofChild { get; set; }
        public string? WillNotes { get; set; }

        public decimal BankBalance { get; set; }
    }

    public enum AccountType
    {
        Savings,
        LTDeposits,
        InvestmentPlans,
        Current,
        ForiegnCurrencyAccounts,
        JointAccount,
        Kids,
        CDS,
        SpecialPurpose,
        Other
    }
}
