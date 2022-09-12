using Business.Models;
using Business.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Travel.Models;

namespace Travel.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly IHomeService _HomeService;

        public HomeController(IHomeService homeService)
        {
            _HomeService = homeService;
        }

        public IActionResult Index()
        {
           List <BlogModel> model = _HomeService.Query().ToList();
            return View(model);
        }

        public PartialViewResult Partial1(int id)
        {
            List<BlogModel> model1 = _HomeService.Query().OrderByDescending(x=>x.Id<=3).Take(2).ToList();
            return PartialView(model1);
        }
        public PartialViewResult Partial2(int id)
        {
            List<BlogModel> model = _HomeService.Query().Where(x => x.Id==4).ToList();

            return PartialView(model);
        }
        public PartialViewResult Partial3()
        {
            List<BlogModel> model = _HomeService.Query().ToList();

            return PartialView(model);
        }
        public PartialViewResult Partial4()
        {
            List<BlogModel> model = _HomeService.Query().Take(2).ToList();

            return PartialView(model);
        }
        public PartialViewResult Partial5()
        {
            List<BlogModel> model = _HomeService.Query().OrderByDescending(x=>x.Id).ToList();

            return PartialView(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Vieww()
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