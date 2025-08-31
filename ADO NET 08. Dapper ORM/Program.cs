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
//var authors = repo.GetAuthors().ToList();
//authors.ForEach(Console.WriteLine);

#endregion

#region Read Data with id
//var author = repo.GetAuthorById(2);
//Console.WriteLine(author);
#endregion

#region Remove Data
//repo.RemoveAuthor(1);
//var authors = repo.GetAuthors().ToList();
//authors.ForEach(Console.WriteLine);
#endregion

#region Remove Datas
//repo.RemoveAuthors([3, 54, 7, 9]);
#endregion


#region Update Data
var author = repo.GetAuthorById(2);
author.FirstName = "Osi";
repo.UpdateAuthor(author);
#endregion
