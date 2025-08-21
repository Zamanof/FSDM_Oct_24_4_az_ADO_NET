using Microsoft.EntityFrameworkCore;

namespace ADO_NET_03._EF_Core;

class StudentContext: DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Students;Integrated Security=True;Trust Server Certificate=True;");
    }
}
