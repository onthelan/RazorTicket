using System;
using System.Collections.Generic;

namespace RazorTicket.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
        
        public List<Ticket> Ticket { get; set; }
    }
}