// Configuration file
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

// connection string in file (Hard code) - not secure 
//string connectionString = @"Server=(localdb)\MSSQLLocalDB;
//                            Database=Library;
//                            Integrated Security=SSPI;
//                            Trust Server Certificate=True";

#region Connection string in xml config file
// Dot.NET Core versiylarda işləmir

//string connectionString = 
//        ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

#endregion

#region Connection string in JSON file
var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json");

var config = builder.Build();
string connectionString = config.GetConnectionString("MyJsonCS")!;
//Console.WriteLine(connectionString);

List<Author> authors = new();

using (var conn = new SqlConnection(connectionString))
{
    conn.Open();
    SqlCommand cmd = new("SELECT * FROM Authors", conn);
    SqlDataReader reader = cmd.ExecuteReader();
    while (reader.Read())
    {
        authors.Add(new Author
        {
            Id = (int)reader["Id"],
            FirstName = reader["FirstName"].ToString()!,
            LastName = reader["LastName"].ToString()!
        });
    }
}

authors.ForEach(Console.WriteLine);
#endregion