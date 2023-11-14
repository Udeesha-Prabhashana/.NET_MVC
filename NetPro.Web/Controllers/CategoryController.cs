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
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
