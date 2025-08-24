using Microsoft.EntityFrameworkCore;

class SchoolContext:DbContext
{
    public SchoolContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SchoolWIthAnnotations;Integrated Security=True;Trust Server Certificate=True;")
            .UseValidationCheckConstraints();
    }

}
