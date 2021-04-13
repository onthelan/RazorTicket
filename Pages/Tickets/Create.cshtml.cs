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
        ViewData["AssignedUserId"] = new SelectList(_context.User, "UserId", "DisplayName");
        ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "CategoryName");
        ViewData["PriorityId"] = new SelectList(_context.Set<Priority>(), "PriorityId", "PriorityName");
        ViewData["ReportingUserId"] = new SelectList(_context.User, "UserId", "DisplayName");
        ViewData["StatusId"] = new SelectList(_context.Set<Status>(), "StatusId", "StatusName");
        ViewData["SubcategoryId"] = new SelectList(_context.Set<Subcategory>(), "SubcategoryId", "SubcategoryName");
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

            return RedirectToPage("./Index");
        }
    }
}
