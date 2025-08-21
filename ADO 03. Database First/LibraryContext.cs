using Microsoft.EntityFrameworkCore;

namespace ADO_03._Database_First;

class LibraryContext: DbContext
{
    public LibraryContext()
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Lib> Libs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
         optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=True;Trust Server Certificate=True;");
    }

}
