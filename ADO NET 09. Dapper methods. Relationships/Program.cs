using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

SqlConnection db = new(@"Server=(localdb)\mssqllocaldb;Database=Library;Trusted_Connection=True;");

#region ExecuteScalar
//var result = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Books");
//Console.WriteLine(result);
//Console.WriteLine(db.ExecuteScalar<float>("SELECT AVG(Pages) FROM Books"));
#endregion

#region Single Row Query - QueryFirst, QueryFirstOrDefault, QuerySingle, QuerySingleOrDefault
//var book = db.QueryFirstOrDefault<Book>(@"
//SELECT *
//FROM Books
//WHERE Name LIKE @Name", new {@Name="%Visual%"});
//if (book is not null) Console.WriteLine(book);
//else Console.WriteLine("Book Not Found");
/*
SELECT TOP(1) *
FROM Books
WHERE Name LIKE '%Visual%'
*/

//var book1 = db.QuerySingleOrDefault<Book>(@"
//SELECT *
//FROM Books
//WHERE Name LIKE @Name", new { @Name = "%Mathcad%" });
//if (book1 is not null) Console.WriteLine(book1);
//else Console.WriteLine("Book Not Found");

#endregion

#region Query
//var books = db.Query<Book>("SELECT * FROM Books").ToList();
//books.ForEach(Console.WriteLine);
#endregion

#region QueryMultiple, Read, ReadFirst,ReadFirstOrDefault, ReadSingle, ReadSingleOrDefault
//var sqlQuery = @"
//SELECT * FROM Authors WHERE FirstName = @FirstName;
//SELECT * FROM Books WHERE Id > @Id;
//";

//var results = db.QueryMultiple(sqlQuery, new { @FirstName = "Mark", @Id = 4 });

//var authors = results.Read<Author>().ToList();
//var books = results.Read<Book>().ToList();

//authors.ForEach(Console.WriteLine);
//Console.WriteLine();
//books.ForEach(Console.WriteLine);

//Console.WriteLine();
//var results1 = db.QueryMultiple(sqlQuery, new { @FirstName = "Mark", @Id = 4 });
//Console.WriteLine(results1.ReadFirstOrDefault<Author>());
//Console.WriteLine(results1.ReadFirstOrDefault<Book>());

#endregion

#region Specific Columns
//var sqlQuery = "SELECT Id, FirstName FROM Authors";

//var authors = db.Query<Author>(sqlQuery).ToList();
//authors.ForEach(Console.WriteLine);
#endregion

#region One To Many
//var sqlQuery = @"
//SELECT *
//FROM Students AS S
//JOIN Groups AS G
//ON S.Id_Group = G.Id
//";

//var students = db.Query<Student, Group, Student>(sqlQuery,
//    (s, g) =>
//    {
//        s.Group = g;
//        return s;
//    }).ToList();
//students.ForEach(Console.WriteLine);
//var groupDict = new Dictionary<int, Group>();
//var groups = db.Query<Student, Group, Group>(sqlQuery,
//    (s, g)=>
//    {
//        if(!groupDict.TryGetValue(g.Id, out var exsitingGroup))
//        {
//            exsitingGroup = g;
//            exsitingGroup.Students = new List<Student>();
//            groupDict.Add(g.Id, exsitingGroup);
//        }
//        exsitingGroup.Students.Add(s);
//        return exsitingGroup;
//    }).Distinct().ToList();

//foreach (var group in groups)
//{
//    Console.WriteLine(group);
//    foreach(var student in group.Students.ToList())
//    {
//        Console.WriteLine($"    {student.FirstName} {student.LastName}");
//    }
//}
#endregion

#region Many To Many
db = new(@"Server=(localdb)\mssqllocaldb;Database=ManyToMany;Trusted_Connection=True;");

var sqlQuery = @"
SELECT *
FROM SocialNetworks AS SN
JOIN SocialNetworkUser AS SNU
ON SN.Id = SNU.SocialNetworksId
JOIN Users AS U
ON U.Id = SNU.UsersId";

var socialNetworks = db.Query<SocialNetwork, User, SocialNetwork>(sqlQuery,
    (sn, u) =>
    {
        sn.Users.Add(u);
        return sn;
    });


foreach (var sn in socialNetworks)
{

    Console.WriteLine(sn);
    foreach (var u in sn.Users)
    {
        Console.WriteLine($"     {u}");
    }
};
#endregion
