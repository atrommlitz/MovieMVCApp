using System.ComponentModel.DataAnnotations;

namespace MovieMVCApp.Models
{
    //Use get and set models to pass information to the database
    public class MovieCollection
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Required]
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public int Length { get; set; }
        public string Format { get; set; }
        public string? Genres { get; set; }
        public string? Notes { get; set; }
        public string? LentTo { get; set; }
    }

}
