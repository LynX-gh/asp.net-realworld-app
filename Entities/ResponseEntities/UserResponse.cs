using System.ComponentModel.DataAnnotations;

namespace RealWorldBackend.Entities.ResponseEntities
{
    public class UserResponse
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

        [Required]
        public required string Token { get; set; }

        [Required]
        public string? Username { get; set; }

        public string? Bio { get; set; }

        public string? Image { get; set; }

        public UserResponse()
        {

        }
    }
}
