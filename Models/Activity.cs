using System;

namespace RazorTicket.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string ActivityDescription { get; set; }
        public DateTime ActivityDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}