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
    public class View_Goods_Money_DonationsModel : PageModel
    {
        private readonly APPPRHlulani.Data.APPPRHlulaniContext _context;

        public View_Goods_Money_DonationsModel(APPPRHlulani.Data.APPPRHlulaniContext context)
        {
            _context = context;
        }

        public IList<GoodsMoneyDonations> GoodsMoneyDonations { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.GoodsMoneyDonations != null)
            {
                GoodsMoneyDonations = await _context.GoodsMoneyDonations.ToListAsync();
            }
        }
    }
}
