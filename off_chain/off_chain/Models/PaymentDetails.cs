using System.ComponentModel.DataAnnotations;

namespace off_chain.Models
{
    public class PaymentDetails
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public string Total { get; set; }
        public Ticket Ticket { get; set; }
        public Payment Payment { get; set; }
    }
}
