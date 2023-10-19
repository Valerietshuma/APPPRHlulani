using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using APPPRHlulani.Data;
using APPPRHlulani.Models;

namespace APPPRHlulani.Pages
{
    public class disasterViewModel : PageModel
    {
        private readonly APPPRHlulani.Data.APPPRHlulaniContext _context;

        public disasterViewModel(APPPRHlulani.Data.APPPRHlulaniContext context)
        {
            _context = context;
        }

        public IList<disaster> disaster { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.disaster != null)
            {
                disaster = await _context.disaster.ToListAsync();
            }
        }
    }
}
