namespace ADO_NET_07._Loadings._Explicit_loading;
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
