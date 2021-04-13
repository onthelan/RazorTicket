using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTicket.Data;
using RazorTicket.Models;

namespace RazorTicket.Pages_Users
{
    public class IndexModel : PageModel
    {
        private readonly RazorTicket.Data.RazorTicketContext _context;

        public IndexModel(RazorTicket.Data.RazorTicketContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User
                .Include(u => u.Department)
                .Include(u => u.Role).ToListAsync();
        }
    }
}
