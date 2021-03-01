using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Online.Classified.App.Models;
using Online.Classified.Data;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ClassifiedController : ControllerBase
    {
        public IClassified _classifiedService;
        public readonly IMapper _mapper;
        public ClassifiedController(IClassified classifiedService, IMapper mapper)
        {
            _classifiedService = classifiedService;
            _mapper = mapper;
        }

        [HttpGet("all")]
        public ActionResult <IEnumerable<ClassifiedReadModel>>Get()
        {
            var classified =  _classifiedService.GetAll();
            return Ok(_mapper.Map<IEnumerable<ClassifiedReadModel>>(classified));
            
        }
        [HttpGet("{id}")]
        public ActionResult <ClassifiedReadModel> GetById(int id)
        {
            var classified =  _classifiedService.GetById(id);
            if (classified == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ClassifiedReadModel>(classified));
          
        }
        [HttpGet("Category/{categoryId}", Name = "GetByCategoryId")]
        public ActionResult <IEnumerable<ClassifiedReadModel>> GetByCategoryId(int categoryId)
        {
            var classified =  _classifiedService.GetByCategoryId(categoryId);
            if (classified == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<ClassifiedReadModel>>(classified));
           
        }

        [HttpPost]
        public ActionResult <ClassifiedCreateModel> Create(Online.Classified.Data.Models.Classified classified)
        {
            var classifiedModel = _mapper.Map<Online.Classified.Data.Models.Classified>(classified);
            _classifiedService.Create(classifiedModel);
            _classifiedService.SaveChanges();
            var classifiedReadModel = _mapper.Map<ClassifiedReadModel>(classifiedModel);

            return CreatedAtRoute(nameof(GetByCategoryId), new { Id = classifiedModel.Id }, classifiedReadModel);
        }

        [HttpPut("{id}")]
        public ActionResult<CategoryReadModel> Update(int id, ClassifiedUpdateModel classified)
        {
            var filteredClassified = _classifiedService.GetById(id);
            if (filteredClassified == null)
            {
                return NotFound();
            }
            _mapper.Map(classified, filteredClassified);
            _classifiedService.Update(filteredClassified);
          //  _classifiedService.SaveChanges();
            return NoContent();
        }
    }
}
