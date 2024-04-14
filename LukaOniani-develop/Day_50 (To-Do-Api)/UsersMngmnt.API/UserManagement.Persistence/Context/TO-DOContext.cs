using Microsoft.EntityFrameworkCore;
using UserManagement.Domain.SubTask;
using UserManagement.Domain.TO_DOs;
using UserManagement.Domain.Userss;



namespace UserManagement.Persistence.Context
{
    public class TO_DOContext : DbContext
    {
        public TO_DOContext(DbContextOptions<TO_DOContext> options) :base(options) 
        {
            
        }

        public DbSet<Userss> users { get; set; }
        public DbSet<ToDos> ToDos { get; set; }
        public DbSet<Subtask> subtasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TO_DOContext).Assembly);
        }
    }
}
