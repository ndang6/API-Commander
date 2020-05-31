using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string title { get; set; }

        [Required]
        public string completed { get; set; }
    }
}