using News.Data;
using News.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace News.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly BlogAppDbContext _context;
        public CategoryService(BlogAppDbContext context)
        {
            _context = context;
        }
        public void Add(Category category, string type)
        {
            if (type.Equals("new"))
            {
                _context.Add(category);
            }
            else
            {               
                _context.Update(category);
            }
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(category => category.Id == id);
            if(category == null)
            {
                return false;
            }
            _context.Remove(category);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        public Category GetById(int? id)
        {
            return _context.Categories.FirstOrDefault(category => category.Id == id);
        }

        public string GetCategoryImage(int id)
        {
            return GetById(id).Thumbnail;
        }

        public string GetCategoryTitle(int id)
        {
            return GetById(id).Name;
        }
    }
}
