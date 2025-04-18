using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model.ProjectManagement
{
    public class ProjectResource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        // URL to file (local path or web URL)
        public string Url { get; set; } = string.Empty;

        // Type: Image, PDF, Doc, Link, etc.
        public string ResourceType { get; set; } = "Image";

        // Optional: for albums or grouped collections, Easy to Filter
        public string? CollectionName { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.Now;

        // Optional notes/description
        public string Notes { get; set; } = string.Empty;

        // Foreign Key
        [Required]
        public int ProjectId { get; set; }

        // Navigation Property
        public Project Project { get; set; } = null!;
    }
}
