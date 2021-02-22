using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Models
{
    public class ClassifiedReadModel
    {
        public int Id { get; set; }     
        public CategoryReadModel Category { get; set; }      
        public string Title { get; set; }     
        public string PictureUrl { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public string PhoneNumber { get; set; }

    }
}
