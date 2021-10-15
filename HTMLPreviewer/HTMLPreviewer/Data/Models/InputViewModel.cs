using System.ComponentModel.DataAnnotations;

namespace HTMLPreviewer.Data.Models
{
    public class InputViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(5_000_000)]
        //[RegularExpression("", ErrorMessage = "Can not be less than 3 characters")]
        public string HTML { get; set; }

        public int Id { get; set; }

    }
}
