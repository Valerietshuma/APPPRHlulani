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
    public class Goods_Money_DonationsModel : PageModel
    {
        private readonly APPPRHlulani.Data.APPPRHlulaniContext _context;

        public Goods_Money_DonationsModel(APPPRHlulani.Data.APPPRHlulaniContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GoodsMoneyDonations GoodsMoneyDonations { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.GoodsMoneyDonations == null || GoodsMoneyDonations == null)
            {
                return Page();
            }

            _context.GoodsMoneyDonations.Add(GoodsMoneyDonations);
            await _context.SaveChangesAsync();

            return RedirectToPage("./View_Goods_Money_Donations");
        }
    }
}
