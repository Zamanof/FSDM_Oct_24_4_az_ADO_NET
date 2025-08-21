using ADO_NET_03._EF_Core;
// EF Core

// Database First
// Code First
// Model First

#region Add Data
//using (StudentContext db = new())
//{
//    Student student1 = new()
//    {
//        FirstName = "John",
//        LastName = "Doe",
//        Age = 25,
//        Group = "A11",
//        Gender = "male"
//    };

//    db.Students.Add(student1);
//    db.SaveChanges();
//}
#endregion

#region ReadData
//using (var db = new StudentContext())
//{
//    var student = db.Students.FirstOrDefault(s => s.Id == 2);
//    if(student is not null) Console.WriteLine(student);
//    else Console.WriteLine("Student not Found");
//}
#endregion

#region Add Datas
//using (StudentContext db = new())
//{
//    List<Student> students = new List<Student>
//    {
//        new Student()
//            {
//                FirstName = "Salam",
//                LastName = "Salamzade",
//                Age = 30,
//                Group = "A8",
//                Gender = "male"
//            },
//        new Student()
//            {
//                FirstName = "Ali",
//                LastName = "Valiyev",
//                Age = 18,
//                Group = "A13",
//                Gender = "male"
//            },
//        new Student()
//            {
//                FirstName = "Aliye",
//                LastName = "Valiyeva",
//                Age = 20,
//                Group = "A13",
//                Gender = "female"
//            }
//    };

//    //foreach (var st in students)
//    //{
//    //    db.Students.Add(st);
//    //}

//    db.Students.AddRange(students);
//    db.SaveChanges();
//}
#endregion

#region Read Datas
//using (StudentContext db = new())
//{
//	//   List<Student> students = new();
//	//Student student;

//	//   for (int i = 0; i <= 32; i++)
//	//{
//	//	student = db.Students.FirstOrDefault(s => s.Id == i)!;

//	//	if (student is not null)
//	//		students.Add(student);
//	//}

//	var students = db.Students.ToList();

//	students.ForEach(Console.WriteLine);
//}
#endregion

#region Delete data
//using var db = new StudentContext();
//db.Remove(db.Students.First());
//db.SaveChanges();

//var deleteStudents = db.Students.Where(s => s.Id < 6);
//db.Students.RemoveRange(deleteStudents);
//db.SaveChanges();

#endregion

#region Update data
//using var db = new StudentContext();

//var student = db.Students.FirstOrDefault(x => x.Id == 15);

//if(student is not null)
//{
//    student.FirstName = "Samire";
//    db.Update(student);
//    db.SaveChanges();
//}
#endregion