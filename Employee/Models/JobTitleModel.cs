using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class JobTitleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobTitleId { get; set; }

        [Required]
        [MaxLength(30)]
        public string JobTitle { get; set; }

        [Required]
        [MaxLength(30)]
        public string Position { get; set; }


        [ForeignKey("JobDescription")]
        public int JobDescriptionId { get; set; }

        // Navigation property to JobDescription
        public JobDescriptionModel JobDescription { get; set; }

        public JobTitleModel()
        {
            JobTitle = string.Empty;
            Position = string.Empty;
        }
    }
}
