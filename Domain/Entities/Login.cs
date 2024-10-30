using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public  class Login
    {
        [Key]
        public string LoginId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Roles { get; set; } 

        public DateTime CreatedDate { get; set; } 
    }
}
