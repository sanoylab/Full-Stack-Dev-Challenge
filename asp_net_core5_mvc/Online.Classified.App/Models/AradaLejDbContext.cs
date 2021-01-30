using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Models
{
    public class AradaLejDbContext: DbContext
    {
        AradaLejDbContext _context;
        public AradaLejDbContext(DbContextOptions<AradaLejDbContext>options): base(options)  { }

        public DbSet<Category> Category { get; set; }
        public DbSet<Classified> Classified { get; set; }
    }
}
