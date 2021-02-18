using System;
using Online.Classified.Data;
using Online.Classified.Data.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Online.Classified.Services 
{
    public class ClassifiedService: IClassifiedService
    {
        private readonly AradaLejDbContext _context;

        public ClassifiedService(AradaLejDbContext context)
        {
            _context = context;
        }

        public void Add(Data.Models.Classified classified, string type)
        {
            if (type == "add")
            {
                _context.Add(classified);
            }
            else
            {
                _context.Update(classified);
            }
            _context.SaveChanges();
        }

        public bool Delete(int Id)
        {
            var classified = _context.Classified.FirstOrDefault(b => b.Id == Id);
            if (classified == null)
            {
                return false;
            }
            _context.Classified.Remove(classified);
            _context.SaveChanges();
            return true;
        }

       
        public Data.Models.Classified GetByCategoryId(int? Id)
        {
            return _context.Classified.FirstOrDefault(p => p.Category.Id == Id);
        }

        public Data.Models.Classified GetById(int? Id)
        {
            return _context.Classified.Include(a=>a.Category).FirstOrDefault(p => p.Id == Id);
        }

        IEnumerable<Data.Models.Classified> IClassifiedService.GetAll()
        {
            return _context.Classified.Include(a=>a.Category);
        }
    }
}
