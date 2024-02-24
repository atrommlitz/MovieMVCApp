using System.ComponentModel.DataAnnotations;

namespace Mission06_Trommlitz.Models
{
    //Create a model for categories to help get and set the CategoryId and Name
    public class Category

    {
        [Key]
        public required int CategoryId { get; set; }
        public required string CategoryName {  get; set; }
    }
}
