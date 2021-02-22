﻿using AutoMapper;
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
        [HttpGet("Category/{categoryId}")]
        public ActionResult <IEnumerable<ClassifiedReadModel>> GetByCategoryId(int categoryId)
        {
            var classified =  _classifiedService.GetByCategoryId(categoryId);
            if (classified == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<ClassifiedReadModel>>(classified));
           
        }
    }
}
