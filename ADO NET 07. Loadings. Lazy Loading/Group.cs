namespace ADO_NET_07._Loadings._Lazy_Loading;
public class Group
{
    public int Id { get; set; }
    public string GroupName { get; set; }
    public virtual List<Student> Students { get; set; } = [];

    public override string ToString()
    {
        return GroupName;
    }
}
