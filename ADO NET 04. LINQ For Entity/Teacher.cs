using System;
using System.Collections.Generic;

namespace ADO_NET_04._LINQ_For_Entity;

public partial class Teacher
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int IdDep { get; set; }

    public virtual Department IdDepNavigation { get; set; } = null!;

    public virtual ICollection<TCard> TCards { get; set; } = new List<TCard>();
}
