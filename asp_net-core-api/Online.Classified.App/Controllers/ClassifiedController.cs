using Microsoft.AspNetCore.Mvc;
using Online.Classified.Data;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassifiedController : ControllerBase
    {
        public IClassified _classifiedService;
        public ClassifiedController(IClassified classifiedService)
        {
            _classifiedService = classifiedService;
        }

        [HttpGet]
        public IEnumerable<Online.Classified.Data.Models.Classified>Get()
        {
            var classified = _classifiedService.GetAll();
            return classified.ToArray();
        }
        [HttpGet("{id}")]
        public Online.Classified.Data.Models.Classified GetById(int id)
        {
            var classified = _classifiedService.GetById(id);
            return classified;
        }
        [HttpGet("ByCategory/{categoryId}")]
        public Online.Classified.Data.Models.Classified GetByCategoryId(int categoryId)
        {
            var classified = _classifiedService.GetByCategoryId(categoryId);
            return classified;
        }
    }
}
