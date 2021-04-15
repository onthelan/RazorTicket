using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorTicket.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserDisplayName { get; set; }
        public string UserEmail { get; set; }

        [InverseProperty("ReportingUser")]
        public List<Ticket> ReportedTickets { get; set; }

        [InverseProperty("AssignedUser")]
        public List<Ticket> AssignedTickets { get; set; }
        
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public List<Activity> Activity { get; set; }
    }
}