namespace ADO_NET_07._Loadings._Explicit_loading;

class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public int GroupId { get; set; }
    public virtual Group Group { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
