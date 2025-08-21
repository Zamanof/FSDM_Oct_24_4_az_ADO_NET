using ADO_NET_04._Code_First._One_to_One;
using Microsoft.EntityFrameworkCore;

using StudentContext db = new();

Student student = new Student()
{
    FirstName = "Salam",
    LastName = "Salamzade",
    BirthDay = new DateTime(2005, 5, 5)
};

StudentCard studentCard = new()
{
    StartDate = new DateTime(2025, 8, 21),
    EndDate = new DateTime(2029, 8, 21),
    Student = student
};
//db.Students.Add(student);
db.StudentCards.Add(studentCard);
db.SaveChanges();

studentCard = db.StudentCards.Include(sc => sc.Student).First();
Console.WriteLine(studentCard);
Console.WriteLine(studentCard.Student);
