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
    public class IndexModel : PageModel
    {
        private readonly RazorTicket.Data.RazorTicketContext _context;

        public IndexModel(RazorTicket.Data.RazorTicketContext context)
        {
            _context = context;
        }

        public IList<Subcategory> Subcategory { get;set; }

        public async Task OnGetAsync()
        {
            Subcategory = await _context.Subcategory
                .Include(s => s.Category).ToListAsync();
        }
    }
}
