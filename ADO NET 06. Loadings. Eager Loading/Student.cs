// Read relational Datas

// + Eager loading
// - Explicit loading
// - Lazy loading
class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int GroupId { get; set; } // Foreign Key
    public virtual Group Group { get; set; } // Navigation Property

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

}
