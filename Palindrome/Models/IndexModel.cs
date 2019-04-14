using System.ComponentModel.DataAnnotations;

namespace Polindrome.Models
{
    public class IndexModel
    {
        [Display(Name = "Please Enter Value")]
        [StringLength(250, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        [Required]
        public string Word { get; set; }

        public bool IsPalindrome { get; set; }
    }
}
