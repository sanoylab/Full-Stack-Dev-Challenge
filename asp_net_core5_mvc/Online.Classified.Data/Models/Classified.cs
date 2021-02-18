
using System.ComponentModel.DataAnnotations;


namespace Online.Classified.Data.Models
{
    public class Classified
    {
        [Key]
        public int Id { get; set; }
       
        [Required(ErrorMessage = "Category is required.")]       
        public Category Category {get; set;}
       
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Picture URL is required.")]
        public string PictureUrl { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsRecommended { get; set; }
    }
}
