// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class Teacher
{
    [Key] // property-ni PRIMARY KEY olaraq elan edir
    [Column("Id")]
    // TeacherId (EF) -> Id (Db)
    public int TeacherId { get; set; }

    [Required]
    [MaxLength(30)]
    public string? FirstName { get; set; }

    [Required]
    [MaxLength(30)]
    public string? LastName { get; set; }

    [Required]
    [Column(TypeName ="varchar(50)")] 
    // DB-de hansi datatype olacaqini teyin edir
    public string? Email { get; set; }
    public DateTime BirthDay { get; set; }
    public float Salary { get; set; }
    public float Bonus { get; set; }
}
