using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class JobDescriptionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobDescriptionId { get; set; }

        public DateTime StartDate { get; set; }

        public string EndDate { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        // Navigation property to Employee
        public EmployeeModel Employee { get; set; }

        // Navigation property to JobTitles
        public ICollection<JobTitleModel> JobTitles { get; set; }

        public JobDescriptionModel()
        {
            EndDate = string.Empty;
            JobTitles = new HashSet<JobTitleModel>();
        }
    }
}
