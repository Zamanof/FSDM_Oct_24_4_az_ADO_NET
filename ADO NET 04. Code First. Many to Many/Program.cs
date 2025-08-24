// Code first -> Many to Many

using (SocialNetworkContext db = new())
{
    SocialNetwork facebook = new() { Name = "Facebook" };
    SocialNetwork instagram = new() { Name = "Instagram" };
    SocialNetwork threads = new() { Name = "Threads" };

    User user = new() { 
        FirstName = "Nadir",
        LastName = "Zamanov",
        Login="zamanov@itstep.org",
        Password = "qwerty123456789"
    };
    User user1 = new User()
    {
        FirstName = "Ali",
        LastName = "Alizade",
        Login = "AliAli",
        Password = "654321"
    };

    facebook.Users.Add(user);
    facebook.Users.Add(user1);
    instagram.Users.Add(user);
    threads.Users.Add(user);

    db.SocialNetworks.AddRange(facebook, instagram, threads);
    db.SaveChanges();
}




