using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDAL());
        JobManager jobManager = new JobManager(new EfJobDAL());

        public IActionResult Index()
        {
            var customers = customerManager.GetCustomerWithJob();
            return View(customers);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            List<SelectListItem> jobs =
            (from x in jobManager.TGetList()
             select new SelectListItem
             {
                Text = x.Name,
                Value = x.ID.ToString()
             }).ToList();
            ViewBag.job = jobs;
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            CustomerValidator validations = new CustomerValidator();
            ValidationResult result = validations.Validate(customer);
            if (result.IsValid)
            {
                customerManager.TInsert(customer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var custom in result.Errors)
                {
                    ModelState.AddModelError(custom.PropertyName, custom.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteCustomer(int id)
        {
            var customer = customerManager.TGetById(id);
            customerManager.TDelete(customer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            List<SelectListItem> jobs =
            (from x in jobManager.TGetList()
             select new SelectListItem
             {
                 Text = x.Name,
                 Value = x.ID.ToString()
             }).ToList();
            ViewBag.job = jobs;
            var customer = customerManager.TGetById(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            customerManager.TUpdate(customer);
            return RedirectToAction("Index");
        }
    }
}
