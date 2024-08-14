using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class EmployeeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmployeeName { get; set; }

        // Navigation property to JobDescriptions
        public ICollection<JobDescriptionModel> JobDescriptions { get; set; }

        public EmployeeModel()
        {
            EmployeeName = string.Empty;
            JobDescriptions = new HashSet<JobDescriptionModel>();
        }
    }
}
