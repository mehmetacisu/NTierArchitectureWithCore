using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDAL());
        public IActionResult Index()
        {
            var categories = categoryManager.TGetList();
            return View(categories);
        }
    }
}
