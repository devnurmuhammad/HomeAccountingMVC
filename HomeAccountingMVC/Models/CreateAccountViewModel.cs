using System.ComponentModel.DataAnnotations;

namespace HomeAccountingMVC.Models
{
    public class CreateAccountViewModel
    {
        public string? Firstname { get; set; }
        [Required]
        public required string Username { get; set; }
        [Required]
        public required string Password { get; set; }
        public string? Email { get; set; }
    }
}
