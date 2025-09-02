class SocialNetwork
{
    public int Id { get; set; }
    public  string Name { get; set; }
    public virtual List<User> Users { get; set; } = [];
    public override string ToString()
    {
        return Name;
    }
}