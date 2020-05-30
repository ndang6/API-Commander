using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(250)]
        public string title { get; set; }

        [Required]
        public string completed { get; set; }

    }
}