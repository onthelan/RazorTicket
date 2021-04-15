using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTicket.Data;
using RazorTicket.Models;

namespace RazorTicket.Pages_Activities
{
    public class DeleteModel : PageModel
    {
        private readonly RazorTicket.Data.RazorTicketContext _context;

        public DeleteModel(RazorTicket.Data.RazorTicketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Activity Activity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Activity = await _context.Activity
                .Include(a => a.Ticket)
                .Include(a => a.User).FirstOrDefaultAsync(m => m.ActivityId == id);

            if (Activity == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Activity = await _context.Activity.FindAsync(id);

            if (Activity != null)
            {
                _context.Activity.Remove(Activity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
