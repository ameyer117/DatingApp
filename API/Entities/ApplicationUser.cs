using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class ApplicationUser
{
    public int Id { get; set; }
    
    [StringLength(255, ErrorMessage = "UserName can not be longer than 255 characters.")]
    public required string UserName { get; set; }
}