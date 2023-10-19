using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using APPPRHlulani.Data;
using APPPRHlulani.Models;

namespace APPPRHlulani.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly APPPRHlulani.Data.APPPRHlulaniContext _context;

        public RegisterModel(APPPRHlulani.Data.APPPRHlulaniContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Users Users { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Users == null || Users == null)
            {
                return Page();
            }

            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Login");
        }
    }
}
