using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetPro_Razor.Data;
using NetPro_Razor.Models;

namespace NetPro_Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList {  get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;            
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
