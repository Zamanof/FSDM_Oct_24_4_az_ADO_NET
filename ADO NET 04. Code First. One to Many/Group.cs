namespace ADO_NET_04._Code_First._One_to_Many;

class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
