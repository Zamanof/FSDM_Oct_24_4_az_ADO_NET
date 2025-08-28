using ADO_NET_07._Loadings._Lazy_Loading;
// Read relational Datas

// - Eager loading
// - Explicit loading
// + Lazy loading

using ApplicatonContext db = new();
#region Add Data
//List<Student> studentsProgramming = new List<Student>
//        {
//            new Student { FirstName = "Nurlan", LastName = "Aliyev", Age = 20 },
//            new Student { FirstName = "Aysel", LastName = "Huseynova", Age = 19 },
//            new Student { FirstName = "Elvin", LastName = "Mammadov", Age = 21 },
//            new Student { FirstName = "Sevinc", LastName = "Ismayilova", Age = 20 },
//            new Student { FirstName = "Rauf", LastName = "Tagiyev", Age = 22 },
//            new Student { FirstName = "Leyla", LastName = "Guliyeva", Age = 18 },
//            new Student { FirstName = "Kamran", LastName = "Suleymanov", Age = 23 },
//            new Student { FirstName = "Gunay", LastName = "Aliyeva", Age = 19 },
//            new Student { FirstName = "Orxan", LastName = "Karimov", Age = 20 },
//            new Student { FirstName = "Zehra", LastName = "Rahimova", Age = 18 },
//            new Student { FirstName = "Murad", LastName = "Qasimov", Age = 21 },
//            new Student { FirstName = "Sabina", LastName = "Mammadova", Age = 20 },
//            new Student { FirstName = "Samir", LastName = "Isgandarov", Age = 22 },
//            new Student { FirstName = "Nigar", LastName = "Yusifova", Age = 19 },
//            new Student { FirstName = "Emin", LastName = "Quliyev", Age = 20 },
//            new Student { FirstName = "Lala", LastName = "Aliyeva", Age = 18 },
//            new Student { FirstName = "Farid", LastName = "Huseynov", Age = 21 },
//            new Student { FirstName = "Aytac", LastName = "Mammadova", Age = 22 },
//            new Student { FirstName = "Cavid", LastName = "Tagiyev", Age = 20 },
//            new Student { FirstName = "Fidan", LastName = "Karimova", Age = 19 },
//            new Student { FirstName = "Ramil", LastName = "Rahimov", Age = 23 },
//            new Student { FirstName = "Sevinj", LastName = "Ismayilova", Age = 20 },
//            new Student { FirstName = "Ilkin", LastName = "Suleymanov", Age = 22 },
//            new Student { FirstName = "Aygun", LastName = "Qasimova", Age = 18 },
//            new Student { FirstName = "Tural", LastName = "Aliyev", Age = 21 },
//            new Student { FirstName = "Konul", LastName = "Mammadova", Age = 20 },
//            new Student { FirstName = "Vugar", LastName = "Isgandarov", Age = 22 },
//            new Student { FirstName = "Afaq", LastName = "Huseynova", Age = 19 },
//            new Student { FirstName = "Elmar", LastName = "Yusifov", Age = 21 },
//            new Student { FirstName = "Shabnam", LastName = "Tagiyeva", Age = 20 }
//        };
//List<Student> studentsCyberCecurity = new List<Student>
//{
//    new Student { FirstName = "Rashad", LastName = "Aliyev", Age = 20 },
//    new Student { FirstName = "Sevda", LastName = "Huseynova", Age = 19 },
//    new Student { FirstName = "Anar", LastName = "Mammadov", Age = 22 },
//    new Student { FirstName = "Ulker", LastName = "Ismayilova", Age = 18 },
//    new Student { FirstName = "Vusal", LastName = "Tagiyev", Age = 21 },
//    new Student { FirstName = "Gulnar", LastName = "Rahimova", Age = 20 },
//    new Student { FirstName = "Samira", LastName = "Karimova", Age = 19 },
//    new Student { FirstName = "Adil", LastName = "Suleymanov", Age = 23 },
//    new Student { FirstName = "Jale", LastName = "Aliyeva", Age = 20 },
//    new Student { FirstName = "Ramin", LastName = "Qasimov", Age = 21 },
//    new Student { FirstName = "Aydan", LastName = "Mammadova", Age = 18 },
//    new Student { FirstName = "Eldar", LastName = "Isgandarov", Age = 22 },
//    new Student { FirstName = "Aynur", LastName = "Tagiyeva", Age = 19 },
//    new Student { FirstName = "Zaur", LastName = "Karimov", Age = 20 },
//    new Student { FirstName = "Leman", LastName = "Rahimova", Age = 21 },
//    new Student { FirstName = "Ferhad", LastName = "Aliyev", Age = 22 },
//    new Student { FirstName = "Maya", LastName = "Suleymanova", Age = 19 },
//    new Student { FirstName = "Orxan", LastName = "Huseynov", Age = 20 },
//    new Student { FirstName = "Gunel", LastName = "Mammadova", Age = 18 },
//    new Student { FirstName = "Arif", LastName = "Quliyev", Age = 23 }
//};

//List<Student> studentsDesigners = new List<Student>
//{
//    new Student { FirstName = "Ilgar", LastName = "Aliyev", Age = 21 },
//    new Student { FirstName = "Nazrin", LastName = "Huseynova", Age = 19 },
//    new Student { FirstName = "Elchin", LastName = "Mammadov", Age = 22 },
//    new Student { FirstName = "Naila", LastName = "Ismayilova", Age = 20 },
//    new Student { FirstName = "Kamila", LastName = "Tagiyeva", Age = 18 },
//    new Student { FirstName = "Tofig", LastName = "Rahimov", Age = 23 },
//    new Student { FirstName = "Lale", LastName = "Karimova", Age = 19 },
//    new Student { FirstName = "Rashid", LastName = "Suleymanov", Age = 20 },
//    new Student { FirstName = "Sevinc", LastName = "Aliyeva", Age = 21 },
//    new Student { FirstName = "Adnan", LastName = "Qasimov", Age = 22 },
//    new Student { FirstName = "Aysel", LastName = "Mammadova", Age = 20 },
//    new Student { FirstName = "Rauf", LastName = "Isgandarov", Age = 23 },
//    new Student { FirstName = "Sabina", LastName = "Tagiyeva", Age = 19 },
//    new Student { FirstName = "Murad", LastName = "Karimov", Age = 20 },
//    new Student { FirstName = "Zahra", LastName = "Rahimova", Age = 21 },
//    new Student { FirstName = "Emin", LastName = "Aliyev", Age = 18 },
//    new Student { FirstName = "Aytac", LastName = "Suleymanova", Age = 19 },
//    new Student { FirstName = "Cavid", LastName = "Huseynov", Age = 20 },
//    new Student { FirstName = "Gulshan", LastName = "Mammadova", Age = 22 },
//    new Student { FirstName = "Nihad", LastName = "Quliyev", Age = 23 },
//    new Student { FirstName = "Samira", LastName = "Tagiyeva", Age = 20 },
//    new Student { FirstName = "Fuad", LastName = "Aliyev", Age = 21 },
//    new Student { FirstName = "Aygun", LastName = "Ismayilova", Age = 19 },
//    new Student { FirstName = "Ramil", LastName = "Karimov", Age = 22 },
//    new Student { FirstName = "Nigar", LastName = "Rahimova", Age = 20 }
//};

//db.Groups.AddRange(
//    new Group { GroupName = "DesignerGroup", Students = studentsDesigners },
//    new Group { GroupName = "DeveloperGroup", Students = studentsProgramming },
//    new Group { GroupName = "CyberSecurityGroup", Students = studentsCyberCecurity }

//    );

//db.SaveChanges();
#endregion

#region Lazy Loading
/*
Lazy loading ile ishlemek uchun
1. Microsoft.EntityFrameworkCore.Proxies nuget package yuklenmelidir
2. Konfiqurasiyaya .UseLazyLoadingProxies() elave edilmelidir
3. Relation(eleaqeler) ile baqli property-ler (navigation property ve s.) 
    virtual olmalidir ve toreme uchun achiq olmalidir
4. Modelleri tesvir eden butun class-lar public olmalidir
*/

var groups = db.Groups.ToList();
foreach (var group in groups)
{
    Console.WriteLine(group);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"        {student}");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.ReadKey();
var groups2 = db.Groups.ToList();

foreach (var group in groups2)
{
    Console.WriteLine(group);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"        {student}");
    }
    Console.WriteLine();
}

#endregion