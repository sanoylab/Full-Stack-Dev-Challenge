
using System.Collections.Generic;
using Online.Classified.Data.Models;

namespace Online.Classified.Data
{
   public interface IClassifiedService
    {
        IEnumerable<Online.Classified.Data.Models.Classified> GetAll();

        Online.Classified.Data.Models.Classified GetById(int? Id);
        Online.Classified.Data.Models.Classified GetByCategoryId(int? Id);
        void Add(Online.Classified.Data.Models.Classified classified, string type);
        bool Delete(int Id);

    }
}
