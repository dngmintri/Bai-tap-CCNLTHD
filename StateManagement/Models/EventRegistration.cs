using System.ComponentModel.DataAnnotations;

public class EventRegistration
{
    [Required]
    [StringLength(50)]
    public string Name {get; set;}

    [Required]
    [EmailAddress]
    public string Email {get; set;}

    [Required]
    [Range(1,10)]
    public int NumberOfAttendees {get; set;}

}