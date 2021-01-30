using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Models
{
    public class Classified
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Category")]
        [Required(ErrorMessage = "Category is required.")]
        public int CategoryId { get; set; }
       
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
