using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectDI.Infrastructure;
using ProjectDI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace ProjectDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepo _repo;

        public HomeController(ILogger<HomeController> logger, IStudentRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index()
        {
            /*var items = _repo.GetAll();
            return View(items);*/
            TechnologyDropDown();
            return View();
        }
        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_repo.GetAll().ToList().ToDataSourceResult(request));
        }
        public ActionResult Create([DataSourceRequest] DataSourceRequest request, Student model)
        {
            _repo.Create(model);
            return RedirectToAction("Index");
        }

        /*public IActionResult Details(int ID)
        {
            var item = _repo.GetByID(ID);
            return View(item);
        }*/
        public ActionResult Delete([DataSourceRequest] DataSourceRequest request, Student model)
        {
            _repo.Delete(model);
            return RedirectToAction("Index");
        }
        private void TechnologyDropDown()
        {
            try
            {
                List<Technology> TechnologyDropDown = new List<Technology>();
                TechnologyDropDown = _repo.GetTechnologyList().ToList();

                ViewBag.TechnologyDropDown = TechnologyDropDown;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
