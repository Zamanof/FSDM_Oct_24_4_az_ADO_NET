using System;
using System.Collections.Generic;

namespace ADO_NET_06._Loadings._Eager_Loaiding_Library;

public partial class SCard
{
    public int Id { get; set; }

    public int IdStudent { get; set; }

    public int IdBook { get; set; }

    public DateTime DateOut { get; set; }

    public DateTime? DateIn { get; set; }

    public int IdLib { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Lib IdLibNavigation { get; set; } = null!;

    public virtual Student IdStudentNavigation { get; set; } = null!;
}
