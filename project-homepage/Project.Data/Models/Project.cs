using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string HeroImage { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string Screenshot { get; set; }
        public string Link { get; set; }
    }
}
