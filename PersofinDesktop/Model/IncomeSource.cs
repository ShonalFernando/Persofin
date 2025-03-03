using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    internal class IncomeSource : Indexable
    {
        public string Name { get; set; } = string.Empty; // Source name (Employer, Client, Business, etc.)
        public IncomeType IncomeType { get; set; }  // Type of income source
        public decimal ExpectedAmount { get; set; } // Expected earnings (optional)

        public string? ContactPerson { get; set; } // Who pays you
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }

        public PaymentFrequency PaymentFrequency { get; set; } // Monthly, Weekly, etc.
        public string? Notes { get; set; }  // Any additional info

        public BankAccount? AccountAttached { get; set; }
    }

    public enum IncomeType
    {
        Salary,
        BusinessRevenue,
        RentalIncome,
        InvestmentReturns,
        Freelance,
        Pension,
        GovernmentAssistance,
        Other
    }

    public enum PaymentFrequency
    {
        OneTime,
        Daily,
        Weekly,
        BiWeekly,
        Monthly,
        Quarterly,
        Annually
    }
}
