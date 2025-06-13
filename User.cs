using System.ComponentModel.DataAnnotations;

namespace RealWorldBackend
{
    public class User
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

        [Required]
        public required string Token { get; set; }

        [Required]
        public string? Username { get; set; }

        public string? Bio {  get; set; }

        public string? Image { get; set; }
    }
}
