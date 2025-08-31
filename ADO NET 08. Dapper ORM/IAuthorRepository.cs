namespace ADO_NET_08._Dapper_ORM;

interface IAuthorRepository
{
    Author AddAuthor(Author author);
    void AddAuthors(IEnumerable<Author> authors);
    void RemoveAuthor(int id);
    void RemoveAuthors(int[] authorIds);
    IEnumerable<Author> GetAuthors();
    Author GetAuthorById(int id);
}
