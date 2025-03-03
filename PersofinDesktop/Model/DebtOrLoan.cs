using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    /// <summary>
    /// Represents a debt or loan with details such as amount borrowed, interest rate, and lender information.
    /// </summary>
    internal class DebtOrLoan : Indexable
    {
        /// <summary>
        /// Gets or sets the total amount borrowed.
        /// </summary>
        [Display(Name = "Amount Borrowed")]
        public decimal AmmountBorrowed { get; set; }

        /// <summary>
        /// Gets or sets the remaining balance of the loan.
        /// </summary>
        [Display(Name = "Remaining Balance")]
        public decimal RemainingBalance { get; set; }

        /// <summary>
        /// Gets or sets the interest rate applied to the loan.
        /// </summary>
        [Display(Name = "Interest Rate (%)")]
        public decimal InterestRate { get; set; }

        /// <summary>
        /// Gets or sets the payment schedule, representing how often payments are made.
        /// </summary>
        [Display(Name = "Payment Schedule (Months)")]
        public decimal PaymentSchedule { get; set; }

        /// <summary>
        /// Gets or sets the name of the lender.
        /// </summary>
        [Display(Name = "Lender Name")]
        public string? LenderName { get; set; }

        /// <summary>
        /// Gets or sets additional lender information.
        /// </summary>
        [Display(Name = "Lender Information")]
        public ObservableCollection<string> LenderInfo { get; set; } = [];

        /// <summary>
        /// Gets or sets the bank account associated with the loan.
        /// </summary>
        [Display(Name = "Attached Bank Account")]
        public BankAccount? AttachedBankAccount { get; set; }
    }
}
