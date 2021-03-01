using News.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category GetById(int ? id);
        string GetCategoryTitle(int id);
        string GetCategoryImage(int id);
        void Add(Category category, string type);
        bool Delete(int id);
    }
}
