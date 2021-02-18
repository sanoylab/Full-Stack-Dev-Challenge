using Microsoft.EntityFrameworkCore;
using Online.Classified.Data;
using Online.Classified.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Online.Classified.Services
{
   public class CategoryService : ICategoryService
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
            return _context.Category.FirstOrDefault(p=>p.Id== Id);
        }
        public void Add(Category category, string type)
        {
            if (type == "add")
            {
                _context.Add(category);
            }
            else
            {
                _context.Update(category);
            }
            _context.SaveChanges();
        }
        public bool Delete(int Id)
        {
            var category =  _context.Category.FirstOrDefault(b => b.Id == Id);
            if (category == null)
            {
                return false;
            }
            _context.Category.Remove(category);
            _context.SaveChanges();
            return true;
        }
    }
}
