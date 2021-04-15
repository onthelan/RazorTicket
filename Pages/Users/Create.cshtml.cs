using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorTicket.Data;
using RazorTicket.Models;

namespace RazorTicket.Pages_Users
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
        ViewData["DepartmentId"] = new SelectList(_context.Department, "DepartmentId", "DepartmentName");
        ViewData["RoleId"] = new SelectList(_context.Role, "RoleId", "RoleName");
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
