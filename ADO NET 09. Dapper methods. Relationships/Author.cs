class Author {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual List<Book> Books { get; set; } = [];
    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName}";
    }
}
