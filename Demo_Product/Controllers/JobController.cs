using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDAL());
        public IActionResult Index()
        {
            var jobs = jobManager.TGetList();
            return View(jobs);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job job)
        {
            jobManager.TInsert(job);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteJob(int id)
        {
            var job = jobManager.TGetById(id);
            jobManager.TDelete(job);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var job = jobManager.TGetById(id);
            return View(job);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job job)
        {
            jobManager.TUpdate(job);
            return RedirectToAction("Index");

        }
    }
}
