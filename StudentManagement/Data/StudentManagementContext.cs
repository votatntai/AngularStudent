using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Data
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManagement.Entities.Student> Student { get; set; }
    }
}