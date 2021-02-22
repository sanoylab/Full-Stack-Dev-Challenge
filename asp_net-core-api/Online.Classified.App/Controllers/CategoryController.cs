using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Online.Classified.App.Models;
using Online.Classified.Data;
using Online.Classified.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]

    public class CategoryController : ControllerBase
    {
        private readonly ICategory _categoryService;

        public readonly IMapper _mapper;

        public CategoryController(ICategory categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("all")]
        public ActionResult <IEnumerable<CategoryReadModel>> Get()
        {
            var category = _categoryService.GetAll();
            return Ok(_mapper.Map<IEnumerable<CategoryReadModel>>(category));
        }
        [HttpGet("{id}")]
        public ActionResult <CategoryReadModel> Get(int id)
        {
            var category =  _categoryService.GetById(id);
            if(category == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CategoryReadModel>(category));
        }
    }
}
