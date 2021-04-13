using System;
using System.Collections.Generic;

namespace RazorTicket.Models
{
    public class Priority
    {
        public int PriorityId { get; set; }
        public string PriorityName { get; set; }
        public string PriorityDescription { get; set; }

        public List<Ticket> Ticket { get; set; }
    }
}