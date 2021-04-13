using Microsoft.EntityFrameworkCore;

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
    }
}