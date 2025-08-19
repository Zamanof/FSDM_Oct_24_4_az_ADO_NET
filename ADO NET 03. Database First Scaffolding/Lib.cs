using System;
using System.Collections.Generic;

namespace ADO_NET_03._Database_First_Scaffolding;

public partial class Lib
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<SCard> SCards { get; set; } = new List<SCard>();

    public virtual ICollection<TCard> TCards { get; set; } = new List<TCard>();
}
