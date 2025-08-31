// Dapper ORM

using ADO_NET_08._Dapper_ORM;
using Microsoft.Data.SqlClient;

var cs = @"Server=(localdb)\mssqllocaldb;Database=Authors;Trusted_Connection=True;";

IAuthorRepository repo = new AuthorRepository(new SqlConnection(), cs);

#region Add Data
//var author = repo.AddAuthor(new Author { FirstName = "Murad", LastName = "Ahmedli" });
//Console.WriteLine(author);
#endregion

#region Read Datas
var authors = repo.GetAuthors().ToList();
authors.ForEach(Console.WriteLine);

#endregion
