using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment2.Models.Student> Student { get; set; }
        public DbSet<Assignment2.Models.Subject> Subject { get; set; }
        public DbSet<Assignment2.Models.Exam> Exam { get; set; }
    }
}