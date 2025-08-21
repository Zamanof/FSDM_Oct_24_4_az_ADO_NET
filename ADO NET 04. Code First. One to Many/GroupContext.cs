using Microsoft.EntityFrameworkCore;

namespace ADO_NET_04._Code_First._One_to_Many;

class GroupContext:DbContext
{
    public DbSet<Group> Groups { get; set; }
    public DbSet<Student> Students { get; set; }
    public GroupContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OneToMany;Integrated Security=True;Trust Server Certificate=True;");
    }
}
