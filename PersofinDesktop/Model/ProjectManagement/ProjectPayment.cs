using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model.ProjectManagement
{
    public class ProjectPaymentView
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        public string Notes { get; set; } = string.Empty;

        // Foreign Key
        [Required]
        public int ProjectId { get; set; }

        // Navigation Property
        public Project Project { get; set; } = null!;
    }
}
