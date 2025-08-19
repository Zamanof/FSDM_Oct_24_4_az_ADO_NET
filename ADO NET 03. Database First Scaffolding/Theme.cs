using System;
using System.Collections.Generic;

namespace ADO_NET_03._Database_First_Scaffolding;

public partial class Theme
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
