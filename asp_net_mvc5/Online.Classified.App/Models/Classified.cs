using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online.Classified.App.Models
{
    [Table("Classified")]
    public class Classified
    {
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string PictureUrl { get; set; }
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public bool IsRecommended { get; set; }
    }
}