using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UILayer.Models;
using LogicLayer.Infrastructure;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using DataAccessLayer.Entities;

namespace UILayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentService _studentService;

        public HomeController(ILogger<HomeController> logger, IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            TechnologyDropDown();
            return View();
        }
        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_studentService.GetAll().ToList().ToDataSourceResult(request));
        }
        public ActionResult Create([DataSourceRequest] DataSourceRequest request, Student model)
        {
            _studentService.Create(model);
            return RedirectToAction("Index");
        }
        public ActionResult Delete([DataSourceRequest] DataSourceRequest request, Student model)
        {
            _studentService.Delete(model);
            return RedirectToAction("Index");
        }
        private void TechnologyDropDown()
        {
            try
            {
                List<Technology> TechnologyDropDown = new List<Technology>();
                TechnologyDropDown = _studentService.GetTechnologyList().ToList();

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
