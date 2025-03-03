using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    /// <summary>
    /// Represents a bank account with details such as bank name, account type, and balance.
    /// </summary>
    public class BankAccount : Indexable
    {
        /// <summary>
        /// Gets or sets the bank name.
        /// </summary>
        public string Bank { get; set; } = null!;

        /// <summary>
        /// Gets or sets the branch name.
        /// </summary>
        public string Branch { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name on the account.
        /// </summary>
        [Display(Name = "Account Name")]
        public string NameOnAccount { get; set; } = null!;

        /// <summary>
        /// Gets or sets the type of bank account.
        /// </summary>
        [Display(Name = "Account Type")]
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; } = null!;

        /// <summary>
        /// Gets or sets the encrypted card number.
        /// </summary>
        [Display(Name = "Debid/Credit Card Number")]
        public string CardNumberEnc { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name on the card.
        /// </summary>
        [Display(Name = "Debid/Credit Card Name")] 
        public string NameOnCard { get; set; } = null!;

        /// <summary>
        /// Gets or sets the card expiry month.
        /// </summary>
        public int CardExpiryMonth { get; set; }

        /// <summary>
        /// Gets or sets the card expiry year.
        /// </summary>
        public int CardExpiryYear { get; set; }

        /// <summary>
        /// Gets or sets the card security code.
        /// </summary>
        [Display(Name = "Card`s Security Code")]
        public int CardSecurityCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the joint account member, if applicable.
        /// </summary>
        [Display(Name = "Joint Account Partner`s Name")]
        string? JointAccountMemberName { get; set; }

        /// <summary>
        /// Gets or sets the NIC of the joint account member, if applicable.
        /// </summary>
        [Display(Name = "Joint Account Partner`s Identification Number")]
        public string? JointAccountMemberNIC { get; set; }

        /// <summary>
        /// Gets or sets the name of the child, if applicable.
        /// </summary>
        [Display(Name = "Child`s Name of a Children`s Account")]
        public string? NameofChild { get; set; }

        /// <summary>
        /// Gets or sets notes related to a will, if applicable.
        /// </summary>
        [Display(Name = "Will of the Account Holder")]
        public string? WillNotes { get; set; }

        /// <summary>
        /// Gets or sets the current bank balance.
        /// </summary>
        [Display(Name = "Current Balance of the Account")]
        public decimal BankBalance { get; set; }


        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [Display(Name = "The Representative Currency of the Account")]
        public string Currency { get; set; } = "LKR";
    }

    /// <summary>
    /// Specifies the different types of bank accounts.
    /// </summary>
    public enum AccountType
    {
        [Description("Savings account with interest accumulation")]
        Savings,

        [Description("Long-term deposit accounts with fixed maturity periods")]
        LTDeposits,

        [Description("Investment plans including mutual funds and fixed income investments")]
        InvestmentPlans,

        [Description("Current account for daily transactions")]
        Current,

        [Description("Foreign currency accounts holding non-local currencies")]
        ForiegnCurrencyAccounts,

        [Description("Joint accounts shared by two or more individuals")]
        JointAccount,

        [Description("Bank accounts designed for children")]
        Kids,

        [Description("Central Depository System (CDS) accounts for securities trading")]
        CDS,

        [Description("Accounts created for specific purposes such as escrow or trusts")]
        SpecialPurpose,

        [Description("Other types of bank accounts not covered above")]
        Other
    }

}
