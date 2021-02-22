using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace News.Service
{
    public class PostService : IPostService
    {
        private readonly BlogAppDbContext _context;
        public PostService(BlogAppDbContext context)
        {
            _context = context;
        }
        public void Add(Post post, string type)
        {
            if (type.Equals("new"))
            {
                _context.Add(post);
            }
            else
            {
                _context.Update(post);
            }
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var post = _context.Posts.FirstOrDefault(post => post.Id == id);
            if (post == null)
            {
                return false;
            }
            _context.Remove(post);
            return true;
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.Include(a=>a.Category);
        }

        public IEnumerable<Post> GetByCategory(int categoryId)
        {
            return _context.Posts.Where(post => post.Category.Id == categoryId);
        }

        public Post GetById(int ? id)
        {
            return _context.Posts.Include(a=>a.Category).FirstOrDefault(post => post.Id == id);
        }

        public int GetCategoryId(int id)
        {
            return int.Parse(_context.Posts.Include(a => a.Category).FirstOrDefault(post => post.Id == id).Category.Id.ToString());
        }

        public string GetNumberOfNews(int categoryId)
        {
            return _context.Posts.Where(news => news.Category.Id == categoryId).Count().ToString();
        }

        public IEnumerable<Post> GetRelatedNews(int categoryid, int id)
        {
            var news = _context.Posts.Where(post => post.Category.Id == categoryid && post.Id != id);
            return news;
        }
    }
}
