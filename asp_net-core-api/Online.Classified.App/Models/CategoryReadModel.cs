using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Models
{
    public class CategoryReadModel
    {       
        public int Id { get; set; }     
        public string CategoryImage { get; set; }     
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
