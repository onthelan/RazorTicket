using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorTicket.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        public Ticket Ticket { get; set; }

        [InverseProperty("ReportingUser")]
        public List<Ticket> ReportedBy { get; set; }

        [InverseProperty("AssignedUser")]
        public List<Ticket> AssignedTo { get; set; }
        
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}