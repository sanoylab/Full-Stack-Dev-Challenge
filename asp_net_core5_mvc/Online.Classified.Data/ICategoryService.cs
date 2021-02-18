using Online.Classified.Data.Models;

using System.Collections.Generic;


namespace Online.Classified.Data
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category GetById(int? Id);
        void Add(Category category, string type);
        bool Delete(int Id);

    }
}
