using AutoMapper;
using Online.Classified.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Profiles
{
    public class ClassifiedProfile : Profile
    {
        public ClassifiedProfile()
        {
            CreateMap<Online.Classified.Data.Models.Classified, ClassifiedReadModel>();
            CreateMap<ClassifiedCreateModel, Online.Classified.Data.Models.Classified>();
            CreateMap<CategoryUpdateModel, Online.Classified.Data.Models.Classified>();
        }
    }
}
