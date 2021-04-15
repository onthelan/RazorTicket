using System;
using System.Collections.Generic;

namespace RazorTicket.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string TicketDescription { get; set; }
        public DateTime TicketDateOpened { get; set; }
        public DateTime TicketDateModified { get; set; }
        public DateTime TicketDateClosed { get; set; }

        public int ReportingUserId { get; set; }
        public User ReportingUser { get; set; }

        public int AssignedUserId { get; set; }
        public User AssignedUser { get; set;}

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public int PriorityId { get; set; }
        public Priority Priority { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }

        public List<Activity> Activity { get; set; }
    }
}