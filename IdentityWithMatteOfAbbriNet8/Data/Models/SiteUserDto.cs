using System.ComponentModel.DataAnnotations;

namespace IdentityWithMatteOfAbbriNet8.Data.Models
{
    public class SiteUserDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
