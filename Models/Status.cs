using System;

namespace RazorTicket.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
        public Ticket Ticket { get; set; }
    }
}