using System.ComponentModel.DataAnnotations;

namespace APPPRHlulani.Models
{
    public class GoodsMoneyDonations
    {
        [Key]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public int Items { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Donator { get; set; }

        public double Amount { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime money_Date { get; set; }
        public string money_Donator { get; set; }

    }
}
