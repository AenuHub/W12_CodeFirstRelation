using System.ComponentModel.DataAnnotations;

namespace W12_CodeFirstRelation.Data;

public class User
{
    [Required]
    public int Id { get; set; }
    
    [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
    public string Username { get; set; } = string.Empty;
    
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    
    public IEnumerable<Post> Posts { get; set; } = new List<Post>();
}