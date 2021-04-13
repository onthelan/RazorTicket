using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTicket.Data;
using RazorTicket.Models;

namespace RazorTicket.Pages_Subcategories
{
    public class DetailsModel : PageModel
    {
        private readonly RazorTicket.Data.RazorTicketContext _context;

        public DetailsModel(RazorTicket.Data.RazorTicketContext context)
        {
            _context = context;
        }

        public Subcategory Subcategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Subcategory = await _context.Subcategory.FirstOrDefaultAsync(m => m.SubcategoryId == id);

            if (Subcategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
