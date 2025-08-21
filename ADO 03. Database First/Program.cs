using ADO_03._Database_First;

using LibraryContext db = new();

var authors = db.Authors.ToList();
var librarians = db.Libs.ToList();

authors.ForEach(Console.WriteLine);
Console.WriteLine();
librarians.ForEach(Console.WriteLine);
