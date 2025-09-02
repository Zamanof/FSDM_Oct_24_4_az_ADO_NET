class Group {
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdFaculty { get; set; }

    public virtual List<Student> Students { get; set; } = new List<Student>();

    public override string ToString()
    {
        return Name;
    }
}
