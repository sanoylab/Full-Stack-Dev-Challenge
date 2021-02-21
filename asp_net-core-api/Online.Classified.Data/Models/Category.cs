using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online.Classified.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Picture URL is required.")]
        public string CategoryImage { get; set; }
        [Required(ErrorMessage = "Category Name is required.")]
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
