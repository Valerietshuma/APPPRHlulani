using System.ComponentModel.DataAnnotations;

namespace APPPRHlulani.Models
{
    public class Users
    {
        private static int neId = 1;
        private static List<Users> neList = new List<Users>();
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public Users()
        {
            UserID= 1;
            neId++;
        }
    
}
}
