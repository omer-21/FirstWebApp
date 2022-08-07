using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FirstProject.Models;
using Community.Models;

namespace FirstProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FirstProject.Models.Student> Student { get; set; }
        public DbSet<Community.Models.Worker> Worker { get; set; }
    }
}