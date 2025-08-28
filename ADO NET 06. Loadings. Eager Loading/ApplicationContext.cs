// Read relational Datas

// + Eager loading
// - Explicit loading
// - Lazy loading
using Microsoft.EntityFrameworkCore;

class ApplicationContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EagerLoading;Trusted_Connection=True;");
    }
}
