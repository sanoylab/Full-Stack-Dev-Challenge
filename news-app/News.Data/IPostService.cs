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
        string GetNumberOfNews(int categoryId); 
        IEnumerable<Post> GetByCategory(int categoryId);
        void Add(Post post, string type);
        bool Delete(int id);
        int GetCategoryId(int id);
        IEnumerable<Post> GetRelatedNews(int categoryid, int id);
    }
}
