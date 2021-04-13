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
    public class IndexModel : PageModel
    {
        private readonly RazorTicket.Data.RazorTicketContext _context;

        public IndexModel(RazorTicket.Data.RazorTicketContext context)
        {
            _context = context;
        }

        public IList<Priority> Priority { get;set; }

        public async Task OnGetAsync()
        {
            Priority = await _context.Priority.ToListAsync();
        }
    }
}
