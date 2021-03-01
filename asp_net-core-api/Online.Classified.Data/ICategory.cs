using Online.Classified.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online.Classified.Data
{
    public interface ICategory
    {
        IEnumerable<Category> GetAll();
        Category GetById(int? Id);
        void Create(Category category);
        void Update(Category category);
        bool SaveChanges();
      
    }
}
