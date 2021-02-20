using News.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data
{
    public interface IPostService
    {
        IEnumerable<Post> GetAll();
        Post GetById(int ? id);
        IEnumerable<Post> GetByCategory(int categoryId);
        void Add(Post post, string type);
        bool Delete(int id);
    }
}
