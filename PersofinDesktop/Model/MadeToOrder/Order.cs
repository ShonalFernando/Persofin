using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Primary Key

        [Required]
        public DateTime DateRecorded { get; set; } = DateTime.Now;

        [Required]
        public DateTime DateOfDelivery { get; set; }

        public string OrderInformation { get; set; } = string.Empty;

        // Navigation property (1 - N)
        public List<OrderPayment> Payments { get; set; } = new();
    }
}
