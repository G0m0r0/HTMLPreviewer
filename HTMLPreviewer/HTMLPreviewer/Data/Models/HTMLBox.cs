namespace HTMLPreviewer.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class HTMLBox
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(5_000_000)]
        public string HTML { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdit { get; set; }
    }
}
