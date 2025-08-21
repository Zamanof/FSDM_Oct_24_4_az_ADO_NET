using ADO_NET_04._Code_First._One_to_Many;

using (GroupContext db = new())
{
    var group = new Group() {
        Name = "FSDM_Oct_24_4_az",
        Students = new List<Student>()
        {
            new Student
            {
                FirstName = "Salam",
                LastName = "Salamzade",
                BirthDay = new DateTime(5,5,5)
            },
            new Student
            {
                FirstName = "Xalam",
                LastName = "Xalamzade",
                BirthDay = new DateTime(6,6,6)
            },
            new Student
            {
                FirstName = "Balam",
                LastName = "Balamzade",
                BirthDay = new DateTime(7,7,7)
            },
            new Student
            {
                FirstName = "Xalat",
                LastName = "Xalatzade",
                BirthDay = new DateTime(8,8,8)
            }
        }
    };

    db.Groups.Add(group);
    db.SaveChanges();

}

