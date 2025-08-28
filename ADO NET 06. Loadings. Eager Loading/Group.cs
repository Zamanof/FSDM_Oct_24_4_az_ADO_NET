// Read relational Datas

// + Eager loading
// - Explicit loading
// - Lazy loading
class Group
{
    public int Id { get; set; }
    public string GroupName { get; set; }
    public List<Student> Students { get; set; } = [];

    public override string ToString()
    {
        return GroupName;
    }
}
