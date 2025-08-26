using Microsoft.EntityFrameworkCore;

class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public StudentContext()
    {
        //Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MigrationsDB;Integrated Security=True;Trust Server Certificate=True;");
    }
}
