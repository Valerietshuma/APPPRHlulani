using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APPPRHlulani.Models;

namespace APPPRHlulani.Data
{
    public class APPPRHlulaniContext : DbContext
    {
        public APPPRHlulaniContext (DbContextOptions<APPPRHlulaniContext> options)
            : base(options)
        {
        }

        public DbSet<APPPRHlulani.Models.Users> Users { get; set; } = default!;

        public DbSet<APPPRHlulani.Models.login> login { get; set; } = default!;

        public DbSet<APPPRHlulani.Models.disaster> disaster { get; set; } = default!;

        public DbSet<APPPRHlulani.Models.GoodsMoneyDonations> GoodsMoneyDonations { get; set; } = default!;
    }
}
