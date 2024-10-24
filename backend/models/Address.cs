using System.ComponentModel.DataAnnotations;

namespace RegistrationProject.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Street { get; set; } = string.Empty;
        
        [Required]
        public string City { get; set; } = string.Empty;
        
        [Required]
        public string State { get; set; } = string.Empty;
        
        [Required]
        public string ZipCode { get; set; } = string.Empty;
    }
}