using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorTicket.Data;
using RazorTicket.Models;

namespace RazorTicket.Pages_Tickets
{
    public class EditModel : PageModel
    {
        private readonly RazorTicket.Data.RazorTicketContext _context;

        public EditModel(RazorTicket.Data.RazorTicketContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["AssignedUserId"] = new SelectList(_context.User, "UserId", "DisplayName");
           ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName");
           ViewData["PriorityId"] = new SelectList(_context.Set<Priority>(), "PriorityId", "PriorityName");
           ViewData["ReportingUserId"] = new SelectList(_context.User, "UserId", "DisplayName");
           ViewData["StatusId"] = new SelectList(_context.Set<Status>(), "StatusId", "StatusName");
           ViewData["SubcategoryId"] = new SelectList(_context.Set<Subcategory>(), "SubcategoryId", "SubcategoryName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ticket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketExists(Ticket.TicketId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.TicketId == id);
        }
    }
}
