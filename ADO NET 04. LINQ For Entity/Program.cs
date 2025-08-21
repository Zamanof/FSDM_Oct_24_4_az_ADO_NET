// LINQ for Entity

using ADO_NET_04._LINQ_For_Entity;
using Microsoft.EntityFrameworkCore;

using LibraryContext db = new();


#region Where
/*
SELECT *
FROM Authors
WHERE Id > 3 AND Id < 8
*/
//db.Authors.Where(a => a.Id > 3 && a.Id < 8).ToList().ForEach(Console.WriteLine);
//db.Authors.Where(a => a.FirstName == "Mark").ToList().ForEach(Console.WriteLine);
#endregion

#region EF.Functions.Like()
//db.Authors.Where(a => a.FirstName.StartsWith("M")).ToList().ForEach(Console.WriteLine);

//db.Authors.Where(a=> EF.Functions.Like(a.FirstName, "M%")).ToList().ForEach(Console.WriteLine);

//db.Authors.Where(a => EF.Functions.Like(a.FirstName, "_ar%")).ToList().ForEach(Console.WriteLine);
//db.Authors.Where(a => EF.Functions.Like(a.FirstName, "[C-M]%")).ToList().ForEach(Console.WriteLine);

//db.Books.Where(b => EF.Functions.Like(b.Name, "%[0-9]%[0-9]%[0-9]%")).ToList().ForEach(Console.WriteLine);

#endregion

#region First, FirstOrDefault, Single, SingleOrDefault, Find

//var author = db.Authors.FirstOrDefault(a => a.FirstName == "Olga");
//if (author is not null) Console.WriteLine(author);
//else Console.WriteLine("aUTHOR NOT FOUND");

//var author2 = db.Authors.SingleOrDefault(a => a.FirstName == "Mark");
//if (author2 is not null) Console.WriteLine(author2);
//else Console.WriteLine("aUTHOR NOT FOUND");

//var author3 = db.Authors.Find(1001);
//if (author3 is not null) Console.WriteLine(author3);
//else Console.WriteLine("aUTHOR NOT FOUND");
#endregion

#region All, Any
//Console.WriteLine(db.Authors.All(a=> a.FirstName.Length > 5));
//Console.WriteLine(db.Authors.Any(a=> a.FirstName == "Nadir"));
#endregion

#region Select
//var authors = db.Authors.Select(a => 
//new { 
//    Id=a.Id,
//    FullName = $"{a.FirstName} {a.LastName}",
//    Books = a.Books
//});

//foreach (var author in authors)
//{
//    Console.WriteLine($"{author.Id}. {author.FullName}");
//    foreach (var book in author.Books)
//    {
//        Console.WriteLine($"\t{book}");
//    }
//}
#endregion

#region OrderBy, OrderByDescending, ThenBy, ThenByDescending

//var authors = db.Authors
//    .OrderBy(a => a.FirstName)
//    .ThenByDescending(a=> a.LastName)
//    .ToList();
//authors.ForEach(Console.WriteLine);

/*
SELECT *
FROM Authors
ORDER BY FirstName, LastName DESC
*/

#endregion

#region Join

//var books = db.Books.Join(db.Authors,
//                          b => b.IdAuthor, a => a.Id,
//                          (b, a) => new
//                          {
//                              Name = b.Name,
//                              Author = $"{a.FirstName} {a.LastName}"
//                          }).ToList();

///*
//SELECT B.[Name], A.FirstName + ' ' + A.LastName AS Author
//FROM Books AS B
//JOIN Authors AS A ON B.Id_Author = A.Id
//*/

//foreach (var item in books)
//{
//    Console.WriteLine($"{item.Name} -> {item.Author}");
//}

#endregion

#region Take, TakeWhile, Skip, SkipWhile
//var authors = db.Authors
//                        .OrderBy(a => a.FirstName)
//                        .Skip(4)
//                        .Take(3)
//                        .ToList();

///*
//SELECT *
//FROM Authors
//ORDER BY FirstName
//OFFSET(4) ROWS
//FETCH NEXT(3) ROWS ONLY
//*/

//authors.ForEach(Console.WriteLine);
#endregion

#region LINQ to Entities
/* 
https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/ef/language-reference/linq-to-entities

https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/ef/language-reference/method-based-query-syntax-examples-projection

LINQ to Entities

        All
        Any
        Average
        Contains
        Count
        First
        FirstOrDefault
        Single
        SingleOrDefault
        Select
        Where
        OrderBy
        OrderByDescending
        ThenBy
        ThenByDescending
        Join
        LeftJoin
        GroupBy
        Except
        Union
        Intersect
        Sum
        Max
        Min
        Take
        TakeWhile
        Skip
        SkipWhile
        ToList

*/
#endregion
