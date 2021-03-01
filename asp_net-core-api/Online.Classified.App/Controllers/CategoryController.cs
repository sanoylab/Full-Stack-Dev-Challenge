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
        public ActionResult <IEnumerable<CategoryReadModel>> GetAll()
        {
            var category = _categoryService.GetAll();
            return Ok(_mapper.Map<IEnumerable<CategoryReadModel>>(category));
        }
        [HttpGet("{id}", Name= "GetById")]
        public ActionResult <CategoryReadModel> GetById(int id)
        {
            var category =  _categoryService.GetById(id);
            if(category == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CategoryReadModel>(category));
        }


        [HttpPost]
        public ActionResult <CategoryReadModel> Create(CategoryCreateModel category)
        {
            
            var categoryModel = _mapper.Map<Category>(category);
            _categoryService.Create(categoryModel);
            _categoryService.SaveChanges();

            var categoryReadModel = _mapper.Map<CategoryReadModel>(categoryModel);

            return CreatedAtRoute(nameof(GetById), new { Id = categoryReadModel.Id }, categoryReadModel);
            //return Ok(categoryReadModel);          
        }

        [HttpPut("{id}")]
        public ActionResult<CategoryReadModel> Update(int id, CategoryUpdateModel category)
        {
            var filteredCategory = _categoryService.GetById(id);
            if(filteredCategory == null)
            {
                return NotFound();
            }
            _mapper.Map(category, filteredCategory);
            _categoryService.Update(filteredCategory);
           // _categoryService.SaveChanges();
            return NoContent();
        }


    }
}
