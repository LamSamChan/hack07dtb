using System.ComponentModel.DataAnnotations;

namespace off_chain.Models
{
    public class Event
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedDate { get; set;}
        [Required]
        public DateTime StartDate { get; set;}
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        public User User { get; set; }
        public ICollection<Ticket> Ticket { get; set; }
        public ICollection<TicketCategory> TicketCategory { get; set; }


    }
}
