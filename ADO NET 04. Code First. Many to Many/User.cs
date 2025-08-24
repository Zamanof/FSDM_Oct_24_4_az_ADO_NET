// Code first -> Many to Many

class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public List<SocialNetwork> SocialNetworks { get; set; } = [];
    public override string ToString()
    {
        return $"{Login} -> {FirstName} {LastName}";
    }
}



