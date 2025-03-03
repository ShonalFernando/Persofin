using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    internal class Assets : Indexable
    { 
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        public decimal PurchaseValue { get; set; }
        public decimal CurrentValue { get; set; }

        public DateTime DatePurchased { get; set; }
        public DateTime? DateSold { get; set; }         //If Sold
    }

    public enum AssetType
    {
        Stock,
        Land,
        LandWithBuilding,
        Vehicles,
        Crypto,
        Gold,
        GemStones,
        Bonds,
        GeneralInvestments,
        CommonInventory,
        Patents,
        Copyrights,
        Artworks,
        Etc
    }
}
