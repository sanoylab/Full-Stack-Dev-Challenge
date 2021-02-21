using Microsoft.AspNetCore.Mvc;
using Online.Classified.Data;
using Online.Classified.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CategoryController : ControllerBase
    {
        private readonly ICategory _categoryService;
        public CategoryController(ICategory categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var categories = _categoryService.GetAll();
            return categories.ToArray();

        }
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            var categories = _categoryService.GetById(id);
            return categories;

        }
    }
}
