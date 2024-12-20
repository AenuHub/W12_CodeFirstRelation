using System.ComponentModel.DataAnnotations;

namespace W12_CodeFirstRelation.Data;

public class Post
{
    [Required]
    public int Id { get; set; }
    
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 2)]
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int UserId { get; set; }
    
    public User User { get; set; }
}