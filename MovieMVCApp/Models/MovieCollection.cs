using Mission06_Trommlitz.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMVCApp.Models
{
    //Use get and set models to pass information to the database
    public class MovieCollection
    {
        [Key]
        [Required]
        public int MovieId {  get; set; }

        //Put a foreign key relationship in the model to help connect to another table in the database

        [ForeignKey("CategoryId")]
        public int? CategoryId {  get; set; }
        public Category? Category {  get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter a Title")]
        public  string Title { get; set; } = string.Empty;

        [Range(1888, 2024, ErrorMessage = "Sorry, you need to enter a valid Year")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter an Edited Option")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter a Copied To Plex")]
        public bool CopiedToPlex { get; set; }
        [StringLength(25)]
        public string? Notes { get; set; }
    }

}
