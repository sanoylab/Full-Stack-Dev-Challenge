﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Online.Classified.App.Models
{
    public class AradaLejDBContext : DbContext
    {
        public DbSet<Classified> Classified { get; set; }
    }
}