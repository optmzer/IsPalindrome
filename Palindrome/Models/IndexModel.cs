using System.ComponentModel.DataAnnotations;

namespace Polindrome.Models
{
    public class IndexModel
    {
        [Display(Name = "Please Enter Value")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="The string should not be empty")]
        //[StringLength(250, ErrorMessage = "The {0} value cannot exceed {1} characters or be smaller then {2} characters", MinimumLength = 1)]
        public string Word { get; set; }

        public bool IsPalindrome { get; set; }
    }
}
