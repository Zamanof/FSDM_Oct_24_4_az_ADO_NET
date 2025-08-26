using System;
using System.Collections.Generic;

namespace ADO_NET_06._Loadings._Eager_Loaiding_Library;

public partial class Author
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
