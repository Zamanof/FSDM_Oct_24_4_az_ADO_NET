// Migration



using StudentContext db = new();
List<Student> students = new()
{
    new Student()
    {
        FirstName = "Alim",
        LastName = "Qasimov",
        Age = 65,
        Email = "alqasim@gmail.com" 
    },
    new Student()
    {
        FirstName = "Vahid",
        LastName = "Zahidoqlu",
        Age = 33,
        Email = "zahidoqlu@gmail.com"
    }
};

db.Students.AddRange(students);
db.SaveChanges();