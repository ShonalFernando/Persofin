using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model.ProjectManagement
{
    public class ProjectTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; } = false;

        // New flag to indicate this task is a milestone
        public bool IsMilestone { get; set; } = false;

        // Foreign Key
        [Required]
        public int ProjectId { get; set; }

        // Navigation property
        public Project Project { get; set; } = null!;
    }
}
