using ADO_NET_06._Loadings._Eager_Loaiding_Library;
using Microsoft.EntityFrameworkCore;



using LibraryContext db = new();

var students = db.Students.Include(s => s.SCards)
                          .ThenInclude(sc => sc.Book)
                          .ToList();

/*
SELECT *
FROM Students AS S
JOIN SCards AS SC ON S.Id = SC.Id_Student
JOIN Books AS B ON B.Id = SC.Id_Book

 
*/


foreach (var student in students)
{

    foreach (var sc in student.SCards)
    {
        if (sc.DateIn is null)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
            Console.WriteLine($"        {sc.Book.Name} {sc.Book.Pages}");
        }
    }

}