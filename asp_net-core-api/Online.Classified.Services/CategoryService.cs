using Online.Classified.Data;
using Online.Classified.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Online.Classified.Services
{
    public class CategoryService : ICategory
    {
        private readonly AradaLejDbContext _context;
        public CategoryService(AradaLejDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetAll()
        {
            return _context.Category;
        }

        public Category GetById(int? Id)
        {
            return _context.Category.FirstOrDefault(category => category.Id == Id);
        }
    }
}
