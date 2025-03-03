using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    /// <summary>
    /// Represents an income source, including details like type, payment frequency, and associated bank account.
    /// </summary>
    internal class IncomeSource : Indexable
    {
        /// <summary>
        /// Gets or sets the name of the income source (Employer, Client, Business, etc.).
        /// </summary>
        [Display(Name = "Income Source Name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of income source.
        /// </summary>
        [Display(Name = "Income Type")]
        public IncomeType IncomeType { get; set; }

        /// <summary>
        /// Gets or sets the expected earnings (optional).
        /// </summary>
        [Display(Name = "Expected Amount")]
        public decimal ExpectedAmount { get; set; }

        /// <summary>
        /// Gets or sets the contact person who pays you.
        /// </summary>
        [Display(Name = "Contact Person")]
        public string? ContactPerson { get; set; }

        /// <summary>
        /// Gets or sets the contact email of the payer.
        /// </summary>
        [Display(Name = "Contact Email")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the contact phone number of the payer.
        /// </summary>
        [Display(Name = "Contact Phone")]
        public string? ContactPhone { get; set; }

        /// <summary>
        /// Gets or sets the payment frequency (e.g., Monthly, Weekly).
        /// </summary>
        [Display(Name = "Payment Frequency")]
        public PaymentFrequency PaymentFrequency { get; set; }

        /// <summary>
        /// Gets or sets any additional notes.
        /// </summary>
        [Display(Name = "Additional Notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the bank account associated with the income source.
        /// </summary>
        [Display(Name = "Attached Bank Account")]
        public BankAccount? AccountAttached { get; set; }
    }

    /// <summary>
    /// Defines different types of income sources.
    /// </summary>
    public enum IncomeType
    {
        [Description("Salary/Wages")] Salary,
        [Description("Business Revenue")] BusinessRevenue,
        [Description("Rental Income")] RentalIncome,
        [Description("Investment Returns")] InvestmentReturns,
        [Description("Freelance Work")] Freelance,
        [Description("Pension Funds")] Pension,
        [Description("Government Assistance")] GovernmentAssistance,
        [Description("Other Income Sources")] Other
    }

    /// <summary>
    /// Defines different payment frequencies for income sources.
    /// </summary>
    public enum PaymentFrequency
    {
        [Description("One-Time Payment")] OneTime,
        [Description("Daily Payment")] Daily,
        [Description("Weekly Payment")] Weekly,
        [Description("Bi-Weekly Payment")] BiWeekly,
        [Description("Monthly Payment")] Monthly,
        [Description("Quarterly Payment")] Quarterly,
        [Description("Annual Payment")] Annually
    }

}
