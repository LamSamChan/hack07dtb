using System.ComponentModel.DataAnnotations;

namespace off_chain.Models
{
    public class Payment
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public DateTime PayTime { get; set; }
        [Required]
        public string Status { get; set; }
        public User User { get; set; }
        
    }
}
