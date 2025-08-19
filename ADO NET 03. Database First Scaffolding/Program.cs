using ADO_NET_03._Database_First_Scaffolding;
// dotnet tool install --global dotnet-ef - install EF Core .NET CLI
// dotnet ef dbcontext scaffold "Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=True;Trust Server Certificate=True;" Microsoft.EntityFrameworkCore.SqlServer



using (var db = new LibraryContext())
{
    var author = db.Authors.FirstOrDefault();
    Console.WriteLine(author.FirstName);
    Console.WriteLine(author.LastName);
}