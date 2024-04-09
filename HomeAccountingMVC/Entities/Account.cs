using System.ComponentModel.DataAnnotations;

namespace HomeAccountingMVC.Entities
{
    public class Account
    {
        public int ID { get; set; }
        public string? Firstname { get; set; }
        [Required]
        public required string Username { get; set; }
        [Required]
        public required string Password { get; set; }
        public string? Email { get; set; }
    }
}
