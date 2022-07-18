using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDAL());
        public IActionResult Index()
        {
            var products = productManager.TGetList();
            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            ProductValidator validations = new ProductValidator();
            ValidationResult result = validations.Validate(product);
            if (result.IsValid)
            {
                productManager.TInsert(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var prod in result.Errors)
                {
                    ModelState.AddModelError(prod.PropertyName, prod.ErrorMessage);
                }
            }
            return View();

        }

        public IActionResult DeleteProduct(int id)
        {
            var product = productManager.TGetById(id);
            productManager.TDelete(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = productManager.TGetById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            productManager.TUpdate(product);
            return RedirectToAction("Index");

        }
    }
}
