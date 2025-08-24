// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

class Group
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string? GroupName { get; set; }

    [Required]
    [Range(0, 12)]
    public int GroupRating { get; set; }

    [Required]
    [Range(1, 4)]
    public int CourseYear { get; set; }
    public List<Student> Students { get; set; } = [];
}
