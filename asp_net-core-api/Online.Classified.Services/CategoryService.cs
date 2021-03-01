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

        public void Create(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            _context.Category.Add(category);
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public Category GetById(int? Id)
        {
            return _context.Category.FirstOrDefault(category => category.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(Category category)
        {
            /*
            var filteredCategory = GetById(category.Id);
            if(filteredCategory == null)
            {
                throw new ArgumentNullException(nameof(filteredCategory));
            }
            _context.Category.Update(filteredCategory);

            */
        }
    }
}
