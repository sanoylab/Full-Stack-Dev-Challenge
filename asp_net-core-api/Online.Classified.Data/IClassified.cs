using System;
using System.Collections.Generic;
using Online.Classified.Data.Models;

namespace Online.Classified.Data
{
    public interface IClassified
    {
        IEnumerable<Online.Classified.Data.Models.Classified> GetAll();

        Online.Classified.Data.Models.Classified GetById(int? Id);
        IEnumerable<Online.Classified.Data.Models.Classified> GetByCategoryId(int? Id);

        void Create(Online.Classified.Data.Models.Classified classified);
        void Update(Online.Classified.Data.Models.Classified classified);

        bool SaveChanges();
    }
}
