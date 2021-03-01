using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Models
{
    public class ClassifiedCreateModel
    {
        
        public CategoryReadModel Category { get; set; } 
        [Required]
        public string Title { get; set; }     
        [Required]
        public string PictureUrl { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsRecommended { get; set; }

    }
}
