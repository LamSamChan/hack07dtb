using System.ComponentModel.DataAnnotations;

namespace off_chain.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Seat { get; set; }
        public Event Event { get; set; }
        public TicketCategory TicketCategory { get; set; }



    }
}
