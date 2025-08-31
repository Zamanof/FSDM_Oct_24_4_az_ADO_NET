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
        throw new NotImplementedException();
    }

    public Author GetAuthorById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Author> GetAuthors()
    {
        var sqlQuery = "SELECT * FROM Author";
        return _db.Query<Author>(sqlQuery);
    }

    public void RemoveAuthor(int id)
    {
        throw new NotImplementedException();
    }

    public void RemoveAuthors(int[] authorIds)
    {
        throw new NotImplementedException();
    }
}
