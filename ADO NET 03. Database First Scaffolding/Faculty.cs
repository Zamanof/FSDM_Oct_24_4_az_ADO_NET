using System;
using System.Collections.Generic;

namespace ADO_NET_03._Database_First_Scaffolding;

public partial class Faculty
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
