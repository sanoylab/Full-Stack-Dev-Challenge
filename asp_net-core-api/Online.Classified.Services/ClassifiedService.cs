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
            return _context.Classified.Include(category=>category.Category).ToList();
        }

        public IEnumerable<Data.Models.Classified> GetByCategoryId(int? Id)
        {
            return _context.Classified.Include(category=>category.Category).Where(classified => classified.Category.Id == Id).ToList();
        }

        public Data.Models.Classified GetById(int? Id)
        {
            return _context.Classified.Include(a => a.Category).FirstOrDefault(classified => classified.Id == Id);
        }
    }
}
