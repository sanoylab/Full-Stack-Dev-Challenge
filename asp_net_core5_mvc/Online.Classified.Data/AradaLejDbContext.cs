using Microsoft.EntityFrameworkCore;
using Online.Classified.Data.Models;



namespace Online.Classified.Data
{
    public class AradaLejDbContext: DbContext
    {
        AradaLejDbContext _context;
        public AradaLejDbContext(DbContextOptions<AradaLejDbContext>options): base(options)  { }

        public DbSet<Category> Category { get; set; }
        public DbSet<Online.Classified.Data.Models.Classified> Classified { get; set; }
    }
}
