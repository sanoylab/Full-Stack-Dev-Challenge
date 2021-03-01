using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace News.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
      
        public Category Category { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string HeroImage { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime CreatedDate { get; set; }
        public string Publisher { get; set; }
    }
}
