using Employee.Models;
using Microsoft.EntityFrameworkCore;


namespace Employee.DataBase
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<EmployeeModel> EmployeeTable { get; set; }

        public DbSet<JobDescriptionModel> jobDescriptionTable { get; set; }

        public DbSet<JobTitleModel> jobTitleTable { get; set; }
    }
}
