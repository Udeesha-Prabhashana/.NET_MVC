using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetPro_Razor.Data;
using NetPro_Razor.Models;

namespace NetPro_Razor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
         private readonly ApplicationDbContext _db;
        
        public  Category Category { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if(id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)           //examine all the validation of the model. only if that true than save the details of the database.
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
