using Microsoft.EntityFrameworkCore;
using Online.Classified.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Online.Classified.Services
{
    public class ClassifiedService : IClassified
    {
        private readonly AradaLejDbContext _context;
        public ClassifiedService(AradaLejDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Data.Models.Classified> GetAll()
        {
            return _context.Classified.Include(category=>category.Category);
        }

        public Data.Models.Classified GetByCategoryId(int? Id)
        {
            return _context.Classified.Include(category=>category.Category).FirstOrDefault(classified => classified.Category.Id == Id);
        }

        public Data.Models.Classified GetById(int? Id)
        {
            return _context.Classified.Include(a => a.Category).FirstOrDefault(classified => classified.Id == Id);
        }
    }
}
