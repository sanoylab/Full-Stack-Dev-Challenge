
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online.Classified.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AradaLejDbContext _context;
        [BindProperty]
        public Category Category { get; set; }

        public CategoryController(AradaLejDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var CategoryList = await _context.Category.ToListAsync();
            return View(CategoryList);
        }
        public IActionResult ManageCategory()
        {
            return View();
        }

        public IActionResult Form(int? id)
        {
            Category = new Category();
            if (id == null)
            {
                //Create New
                return View(Category);
            }
            //Update
            Category = _context.Category.FirstOrDefault(b => b.Id == id);
            if (Category == null)
            {
                return NotFound();
            }
            return View(Category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form()
        {
            if (ModelState.IsValid)
            {
                if (Category.Id == 0)
                {
                    //CREATE
                    _context.Category.Add(Category);

                }
                else
                {
                    _context.Category.Update(Category);
                }
                _context.SaveChanges();

                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Category.ToList()) });

            }

            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Form", Category) });

        }




        #region API CALLS
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _context.Category.ToListAsync() });
        }
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _context.Category.FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _context.Category.Remove(book);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
