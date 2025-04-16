using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PersofinDesktop.Model.ProjectManagement;

namespace PersofinDesktop.Model
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Primary key

        [Required]
        public DateTime DateRecorded { get; set; } = DateTime.Now;

        public DateTime DateStart { get; set; } = DateTime.Now;
        public DateTime DateEnd { get; set; } = DateTime.Now;

        [Required]
        public decimal TotalBudget { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string BudgetInfo { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
        public string Progress { get; set; } = string.Empty;

        [Required]
        public string ProjectStatus { get; set; } = "Waiting";

        [Required]
        public string Category { get; set; } = string.Empty;

        // Need to Impliment Location Mechanism
        public string ProjectLocation { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // 💡 One-to-Many Navigation Property
        public ICollection<ProjectPayment> Payments { get; set; } = new List<ProjectPayment>();
    }
}
