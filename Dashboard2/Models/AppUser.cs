using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Dashboard2.Models
{
    public class AppUser:IdentityUser
    {

        [Key]
        public int EmployeeNumber { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? AlternativePhoneNumber { get; set; }



        [Required]
        public string? KraPin { get; set; }
    }
}
