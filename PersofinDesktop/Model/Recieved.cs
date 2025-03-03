using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    /// <summary>
    /// Represents a received transaction, including details like amount, payment method, and source.
    /// </summary>
    internal class Recieved : Indexable
    {
        /// <summary>
        /// Gets or sets the date the amount was received.
        /// </summary>
        [Display(Name = "Received Date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the type of received transaction.
        /// </summary>
        [Display(Name = "Received Type")]
        public RecievedType RecievedType { get; set; }

        /// <summary>
        /// Gets or sets the description of the received transaction.
        /// </summary>
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty!;

        /// <summary>
        /// Gets or sets the amount received.
        /// </summary>
        [Display(Name = "Amount Received")]
        public decimal Amount { get; set; }

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

        /// <summary>
        /// Gets or sets the bank account where the amount was received.
        /// </summary>
        [Display(Name = "Received to Account")]
        public BankAccount? RecievedToAccount { get; set; }

        /// <summary>
        /// Gets or sets the income source if the received transaction is an income.
        /// </summary>
        [Display(Name = "Income Source")]
        public IncomeSource? IncomeSource { get; set; }
    }

    /// <summary>
    /// Defines different types of received transactions.
    /// </summary>
    public enum RecievedType
    {
        [Description("Salary/Wages")] Salary,
        [Description("Bonus Payment")] Bonus,
        [Description("Business Income")] BusinessIncome,
        [Description("Loan Received")] Loan,
        [Description("Loan Repayment Received")] LoanRepayment,
        [Description("Refund Payment")] Refund,
        [Description("Gift Received")] Gift,
        [Description("Inheritance Funds")] Inheritance,
        [Description("Investment Returns")] InvestmentReturns,
        [Description("Other Received Funds")] Other
    }
}
