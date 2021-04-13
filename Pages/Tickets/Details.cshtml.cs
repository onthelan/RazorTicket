using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTicket.Data;
using RazorTicket.Models;

namespace RazorTicket.Pages_Tickets
{
    public class DetailsModel : PageModel
    {
        private readonly RazorTicket.Data.RazorTicketContext _context;

        public DetailsModel(RazorTicket.Data.RazorTicketContext context)
        {
            _context = context;
        }

        public Ticket Ticket { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ticket = await _context.Ticket
                .Include(t => t.AssignedUser)
                .Include(t => t.Category)
                .Include(t => t.Priority)
                .Include(t => t.ReportingUser)
                .Include(t => t.Status)
                .Include(t => t.Subcategory).FirstOrDefaultAsync(m => m.TicketId == id);

            if (Ticket == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
