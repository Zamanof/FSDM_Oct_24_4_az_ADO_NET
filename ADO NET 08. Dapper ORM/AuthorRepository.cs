using Dapper;
using System.Data;
namespace ADO_NET_08._Dapper_ORM;

class AuthorRepository : IAuthorRepository
{

    private IDbConnection _db;

    public AuthorRepository(IDbConnection db, string cs)
    {
        _db = db;
        _db.ConnectionString = cs;
    }

    public Author AddAuthor(Author author)
    {
        var sqlQuery =
            @"INSERT INTO Author(FirstName, LastName)
              VALUES(@FirstName, @LastName)
              SELECT CAST(SCOPE_IDENTITY() AS int)";
        var id = _db.Query<int>(sqlQuery, new
        {
            @FirstName = author.FirstName,
            @LastName = author.LastName
        }).FirstOrDefault();

        author.Id = id;
        return author;
    }

    public void AddAuthors(IEnumerable<Author> authors)
    {
        foreach (var author in authors)
        {
            AddAuthor(author);
        }
    }

    public Author GetAuthorById(int id)
    {
        var sqlQuery = @"SELECT * FROM Author WHERE Id = @id";
        return _db.QueryFirstOrDefault<Author>(sqlQuery, new { @id = id })!;
    }

    public IEnumerable<Author> GetAuthors()
    {
        var sqlQuery = "SELECT * FROM Author";
        return _db.Query<Author>(sqlQuery);
    }

    public void RemoveAuthor(int id)
    {
        var sqlQuery = "DELETE FROM Author WHERE Id = @id";
        _db.Execute(sqlQuery, new { @id = id });
    }

    public void RemoveAuthors(int[] authorIds)
    {
        foreach (var id in authorIds)
        {
            RemoveAuthor(id);
        }
    }

    public void UpdateAuthor(Author author)
    {
        var sqlQuery =
            @"UPDATE Author 
              SET FirstName=@FirstName, LastName=@LastName
            WHERE Id = @Id";
        //_db.Execute(sqlQuery,
        //    new
        //    {
        //        @Id = author.Id,
        //        @FirstName = author.FirstName,
        //        @LastName = author.LastName
        //    });
        _db.Execute(sqlQuery, author);
    }
}
