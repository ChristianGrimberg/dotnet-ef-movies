using System.ComponentModel.DataAnnotations;

namespace movies
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Range(1900,2099)]
        public int Year { get; set; }
    }
}