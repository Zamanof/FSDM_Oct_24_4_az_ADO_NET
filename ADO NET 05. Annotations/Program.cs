// Annotations


using SchoolContext db = new();


Student student = new()
{
    FirstName = "Ahmed",
    LastName = "Muradli",
};
db.Students.Add(student);
Group group = new()
{
    GroupName = "FSDM_Oct_24_4_az",
    GroupRating = 9,
    CourseYear = 4,
    Students = [student]
};
db.Groups.Add(group);

Student student1 = new()
{
    FirstName = "Murad",
    LastName = "Ahmedli",
    Group = group
};
db.Students.Add(student1);


db.Faculties.Add(new() { FacultyName = "Programming" });

Department department = new()
{
    DepartmentName = "Development"
};

db.Departments.Add(department);

Teacher teacher = new Teacher()
{
    FirstName = "Zaman",
    LastName = "Nadirov",
    BirthDay = new DateTime(1980, 10, 7),
    Salary = 2300156,
    Bonus = 150000,
    Email = "nadirov@itstep.org"
};

Teacher teacher1 = new Teacher()
{
    FirstName = "Seyidmemmed",
    LastName = "Ismayilli",
    BirthDay = new DateTime(1998, 10, 7),
    Salary = 5300300,
    Bonus = 1500000,
    Email = "ismayilli@itstep.org"
};

db.Teachers.AddRange(teacher, teacher1);

db.SaveChanges();
