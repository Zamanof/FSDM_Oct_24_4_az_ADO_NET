using Microsoft.EntityFrameworkCore;

namespace ADO_NET_04._Code_First._One_to_One;

class StudentContext:DbContext
{

    public StudentContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<StudentCard> StudentCards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OneToOne;Integrated Security=True;Trust Server Certificate=True;");
    }

}
