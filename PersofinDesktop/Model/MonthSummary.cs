using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    /// <summary>
    /// Represents a financial summary for a given month and year.
    /// </summary>
    internal class MonthSummary : Indexable
    {
        /// <summary>
        /// Gets or sets the month of the summary.
        /// </summary>
        [Display(Name = "Month")]
        public int Month { get; set; }

        /// <summary>
        /// Gets or sets the year of the summary.
        /// </summary>
        [Display(Name = "Year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the total amount spent in the month.
        /// </summary>
        [Display(Name = "Total Spenditure")]
        public decimal TotalSpenditure { get; set; }

        /// <summary>
        /// Gets or sets the total amount received in the month.
        /// </summary>
        [Display(Name = "Total Received")]
        public decimal TotalRecieved { get; set; }

        /// <summary>
        /// Gets or sets the total income earned in the month.
        /// </summary>
        [Display(Name = "Total Income")]
        public decimal TotalIncome { get; set; }

        /// <summary>
        /// Gets or sets the total expenses for the month.
        /// </summary>
        [Display(Name = "Total Expense")]
        public decimal TotalExpense { get; set; }

        /// <summary>
        /// Gets or sets the total investments made in the month.
        /// </summary>
        [Display(Name = "Total Investments")]
        public decimal TotalInvestments { get; set; }

        /// <summary>
        /// Gets or sets the net profit for the month.
        /// </summary>
        [Display(Name = "Net Profit")]
        public decimal NetProfit { get; set; }
    }

}
