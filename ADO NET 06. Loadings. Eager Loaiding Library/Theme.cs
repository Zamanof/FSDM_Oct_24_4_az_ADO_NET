using System;
using System.Collections.Generic;

namespace ADO_NET_06._Loadings._Eager_Loaiding_Library;

public partial class Theme
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
