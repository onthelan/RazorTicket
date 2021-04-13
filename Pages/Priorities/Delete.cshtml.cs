using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTicket.Data;
using RazorTicket.Models;

namespace RazorTicket.Pages_Priorities
{
    public class DeleteModel : PageModel
    {
        private readonly RazorTicket.Data.RazorTicketContext _context;

        public DeleteModel(RazorTicket.Data.RazorTicketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Priority Priority { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Priority = await _context.Priority.FirstOrDefaultAsync(m => m.PriorityId == id);

            if (Priority == null)
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

            Priority = await _context.Priority.FindAsync(id);

            if (Priority != null)
            {
                _context.Priority.Remove(Priority);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
