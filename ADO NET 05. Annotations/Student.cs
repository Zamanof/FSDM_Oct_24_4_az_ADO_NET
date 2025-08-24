using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class Student
{
    public int Id { get; set; }
    
    [Required]
    // Bu attribut bu column-un vacib olduqunu qeyd edir ve
    // DB-de NOT NULL Olacaq

    [MaxLength(20)] // maksimal uzunluq
    public string? FirstName { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string? LastName { get; set; }

    [ForeignKey("Group")]
    [Column("Id_Group")]
    public int GroupId { get; set; } // ForeignKey

    public virtual Group Group { get; set; } // Navigation property
}
