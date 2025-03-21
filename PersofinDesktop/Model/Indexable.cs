using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    /// <summary>
    /// Represents the indexing for the Entire Data System.
    /// </summary>
    public class Indexable
    {
        /// <summary>
        /// The Main Indexer
        /// Auto incrimenting Simple Identification Number Starting from 0.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Unique Identification Code.
        /// </summary>
        public Guid GUID { get; set; }

        /// <summary>
        /// The Date the entity is Created.
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// The Date the entity is Created.
        /// </summary>
        public DateTime DateModified { get; set; } = DateTime.Now;


        /// <summary>
        /// Owner of the Data, For User Accounts is itself.
        /// </summary>
        public int OwnerID { get; set; }

    }
}