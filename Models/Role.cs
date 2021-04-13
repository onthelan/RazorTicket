using System;
using System.Collections.Generic;

namespace RazorTicket.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }

        public List<User> User { get; set; }
    }
}