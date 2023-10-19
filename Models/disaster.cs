using System.ComponentModel.DataAnnotations;

namespace APPPRHlulani.Models
{
    public class disaster
    {
        [Key]
        [Required]
        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime endDate { get; set; }
        [Required]
        public string Location { get; set; }
        public string Description { get; set; }
        [Required]
        public string Aid { get; set; }
    }
}
