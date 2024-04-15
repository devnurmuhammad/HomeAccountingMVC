using System.ComponentModel.DataAnnotations;

namespace HomeAccountingMVC.DTOs
{
    public class AccountDTO
    {
        public string? Firstname { get; set; }
        [Required]
        public required string Username { get; set; }
        [Required]
        public required string Password { get; set; }
        public string? Email { get; set; }
    }
}
