using Microsoft.AspNetCore.Mvc;
using NetPro.Web.Data;
using NetPro.Web.Models;

namespace NetPro.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category abj)
        {
            if (ModelState.IsValid)           //examine all the validation of the model. only if that true than save the details of the database.
            {
                _db.Categories.Add(abj);
                _db.SaveChanges();
                TempData["success"] = "Category created success";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id==null || id==0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _db.Categories.Find(id);           //use retrive data from the database
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);        --> Another 2 methods to retrive data
            //Category? categoryFromDb2 = _db.Categories.Where(u => u.Id == id).FirstOrDefault();


            if (categoryFromDb==null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category abj)
        {
            if (ModelState.IsValid)           //examine all the validation of the model. only if that true than save the details of the database.
            {
                _db.Categories.Update(abj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _db.Categories.Find(id);           //use retrive data from the database


            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost , ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? obj = _db.Categories.Find(id);
            if (obj == null)           //examine all the validation of the model. only if that true than save the details of the database.
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index", "Category");
        }


    }
}
