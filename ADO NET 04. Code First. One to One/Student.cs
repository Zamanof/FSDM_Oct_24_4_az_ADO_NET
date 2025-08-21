namespace ADO_NET_04._Code_First._One_to_One;

class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? BirthDay { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {BirthDay?.ToShortDateString()}";
    }
}
