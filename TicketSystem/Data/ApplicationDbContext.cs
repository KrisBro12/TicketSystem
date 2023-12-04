using Microsoft.EntityFrameworkCore;
using TicketSystem.Data.Entity;
using Task = TicketSystem.Data.Entity.Task;

namespace TicketSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        internal readonly IEnumerable<object> Users;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }
        public DbSet<Department> department { get; set; }

        public DbSet<Employee> employee { get; set; }

        public DbSet<Task> task { get; set; }

    }
}

