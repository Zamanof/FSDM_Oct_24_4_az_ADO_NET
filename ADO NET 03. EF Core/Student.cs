namespace ADO_NET_03._EF_Core;

class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Group { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName} - {Age}";
    }


}
