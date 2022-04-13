using System.ComponentModel.DataAnnotations;

namespace CamposBankWebApp.Models
{
    public class Account
    {
        public int ID { get; set; }
        
        [Display(Name = "Account Name")]
        [StringLength(12, MinimumLength = 4)]
        [Required]
        public string AccountName { get; set; }
        
        [Display(Name = "First Name")]
        [StringLength(18, MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [StringLength(18, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        public float Balance { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 2)]
        public string Nick { get; set; }

    }
}
