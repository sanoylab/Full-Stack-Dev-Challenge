using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Models
{
    public class CategoryUpdateModel
    {
       [Required]
        public string CategoryImage { get; set; }   
        [Required]
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
