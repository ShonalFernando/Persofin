using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    internal class MonthSummary : Indexable
    {
        public int Month { get; set; }
        public int Year  { get; set; }

        public decimal TotalSpenditure { get; set; }
        public decimal TotalRecieved { get; set; }

        public decimal TotalIncome { get; set; }

        public decimal TotalExpense { get; set; }
        public decimal TotalInvestments { get; set; }

        public decimal NetProfit { get; set; }
    }
}
