using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online.Classified.App.Models
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string CategoryImage { get; set; }
        public string Name { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}