using System;
using System.Collections.Generic;

namespace RazorTicket.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }

        public List<User> User { get; set; }
    }
}