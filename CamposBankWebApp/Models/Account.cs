using System.ComponentModel.DataAnnotations;

namespace CamposBankWebApp.Models
{
    public class Account
    {
        public int ID { get; set; }
        [Display(Name = "Account Name")]
        [Required]
        public string AccountName { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Required]
        public float Balance { get; set; }
        [Required]
        public string Nick { get; set; }

    }
}
