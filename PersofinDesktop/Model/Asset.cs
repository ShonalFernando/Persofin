using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    /// ChatGPT Helped me in Cleaning this Code and Adding Documentation, Other work is done by me 😉

    /// <summary>
    /// Represents an asset with details such as name, location, value, and purchase history.
    /// </summary>
    internal class Asset : Indexable
    {
        /// <summary>
        /// Gets or sets the name of the asset.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the asset.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the location of the asset.
        /// </summary>
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the purchase value of the asset.
        /// </summary>
        public decimal PurchaseValue { get; set; }

        /// <summary>
        /// Gets or sets the current value of the asset.
        /// </summary>
        public decimal CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets the date when the asset was purchased.
        /// </summary>
        public DateTime DatePurchased { get; set; }

        /// <summary>
        /// Gets or sets the date when the asset was sold. Null if not sold.
        /// </summary>
        public DateTime? DateSold { get; set; }
    }

    /// <summary>
    /// Specifies the different types of assets.
    /// </summary>
    public enum AssetType
    {
        [Description("Stock investments including shares and equities")]
        Stock,

        [Description("Land properties without buildings")]
        Land,

        [Description("Land properties with constructed buildings")]
        LandWithBuilding,

        [Description("Motor vehicles including cars, trucks, and motorcycles")]
        Vehicles,

        [Description("Cryptocurrency investments such as Bitcoin, Ethereum")]
        Crypto,

        [Description("Gold assets including bars and coins")]
        Gold,

        [Description("Precious gemstones such as diamonds, rubies, and sapphires")]
        GemStones,

        [Description("Investment bonds including government and corporate bonds")]
        Bonds,

        [Description("General financial investments not categorized elsewhere")]
        GeneralInvestments,

        [Description("Common inventory including office supplies and stock items")]
        CommonInventory,

        [Description("Intellectual property patents")]
        Patents,

        [Description("Intellectual property copyrights")]
        Copyrights,

        [Description("Art pieces including paintings and sculptures")]
        Artworks,

        [Description("Other asset types not specified in the enumeration")]
        Etc
    }
}
