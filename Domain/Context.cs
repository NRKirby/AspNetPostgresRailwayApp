using Microsoft.EntityFrameworkCore;

namespace AspNetPostgresRailwayApp.Domain
{
    public class Context : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
    }
}