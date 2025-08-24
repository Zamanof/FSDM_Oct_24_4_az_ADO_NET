using Microsoft.EntityFrameworkCore;

class SocialNetworkContext :DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<SocialNetwork> SocialNetworks { get; set; }

    public SocialNetworkContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ManyToMany;Integrated Security=True;Trust Server Certificate=True;");
    }
}



