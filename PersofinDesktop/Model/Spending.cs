using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    /// <summary>
    /// Represents a spending transaction, including details like amount, payment method, and type of spending.
    /// </summary>
    internal class Spending : Indexable
    {
        /// <summary>
        /// Gets or sets the date the amount was spent.
        /// </summary>
        [Display(Name = "Spending Date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the type of spending transaction.
        /// </summary>
        [Display(Name = "Spending Type")]
        public SpendType SpendType { get; set; }

        /// <summary>
        /// Gets or sets the description of the spending transaction.
        /// </summary>
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty!;

        /// <summary>
        /// Gets or sets the amount spent.
        /// </summary>
        [Display(Name = "Amount Spent")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the bank account used for the transaction.
        /// </summary>
        [Display(Name = "Spent by Account")]
        public BankAccount? SpentByAccount { get; set; }

        /// <summary>
        /// Gets or sets the payment method used for the transaction.
        /// </summary>
        [Display(Name = "Payment Method")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets additional payment-related information.
        /// </summary>
        [Display(Name = "Payment Information")]
        public ObservableCollection<string> PaymentInfo { get; set; } = new ObservableCollection<string>();
    }

    /// <summary>
    /// Defines different types of spending transactions.
    /// </summary>
    public enum SpendType
    {
        [Description("Personal Expenses")] Personal,
        [Description("Utilities and Bills")] Utlities,
        [Description("Business Turnover")] OtherTurnover,
        [Description("Debt Repayments")] DebtRepayments,
        [Description("Savings Contributions")] Savings,
        [Description("Insurance Payments")] Insurance,
        [Description("Investment Expenses")] Investments,
        [Description("Education Costs")] Education,
        [Description("Personal Development")] PersonalDevelopment,
        [Description("Charitable Donations")] Donations,
        [Description("Gift Expenses")] Gifts,
        [Description("Asset Depreciation")] Depreciation,
        [Description("Other Expenses")] Other
    }

    /// <summary>
    /// Defines different payment methods.
    /// </summary>
    public enum PaymentMethod
    {
        [Description("Cash Payment")] Cash,
        [Description("Credit Card Payment")] CreditCard,
        [Description("Debit Card Payment")] DebitCard,
        [Description("Bank Transfer")] BankTransfer,
        [Description("Mobile Payment")] MobilePayment,
        [Description("Cryptocurrency Payment")] Cryptocurrency,
        [Description("Other Payment Methods")] Other
    }

}
