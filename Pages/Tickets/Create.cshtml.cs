using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorTicket.Data;
using RazorTicket.Models;

namespace RazorTicket.Pages_Tickets
{
    public class CreateModel : PageModel
    {
        private readonly RazorTicket.Data.RazorTicketContext _context;

        public CreateModel(RazorTicket.Data.RazorTicketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AssignedUserId"] = new SelectList(_context.User, "UserId", "UserDisplayName");
        ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName");
        ViewData["PriorityId"] = new SelectList(_context.Priority, "PriorityId", "PriorityName");
        ViewData["ReportingUserId"] = new SelectList(_context.User, "UserId", "UserDisplayName");
        ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusName");
        ViewData["SubcategoryId"] = new SelectList(_context.Subcategory, "SubcategoryId", "SubcategoryName");
        ViewData["AssignedUserEmail"] = new SelectList(_context.User, "UserId", "UserEmail");
            return Page();
        }

        [BindProperty]
        public Ticket Ticket { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ticket.Add(Ticket);
            await _context.SaveChangesAsync();

            EmailAlert.Send("ticket created " + Ticket.TicketId, "ticket created " + Ticket.TicketId, "Chris Peck", "christopher.peck@wakegov.com");

            return RedirectToPage("./Index");
        }
    }
}
