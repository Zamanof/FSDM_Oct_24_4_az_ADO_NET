using Microsoft.EntityFrameworkCore;

namespace ADO_NET_07._Loadings._Explicit_loading;

class ApplicatonContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }

    public ApplicatonContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ExpliocitLoading;Trusted_Connection=True;");
    }
}
