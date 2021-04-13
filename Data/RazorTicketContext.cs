using Microsoft.EntityFrameworkCore;
using RazorTicket.Models;

namespace RazorTicket.Data
{
    public class RazorTicketContext: DbContext
    {
        public RazorTicketContext (
            DbContextOptions<RazorTicketContext> options)
            : base(options)
        {            
        }

        public DbSet<RazorTicket.Models.Ticket> Ticket { get; set; }
        public DbSet<RazorTicket.Models.User> User { get; set; }
        public DbSet<RazorTicket.Models.Role> Role { get; set; }
        public DbSet<RazorTicket.Models.Category> Category { get; set; }
        public DbSet<RazorTicket.Models.Department> Department { get; set; }
        public DbSet<RazorTicket.Models.Priority> Priority { get; set; }
        public DbSet<RazorTicket.Models.Subcategory> Subcategory { get; set; }
    }
}