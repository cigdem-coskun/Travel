using Business.Models;
using Business.Service;
using Business.Service.Bases;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

     

       
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }


        public IActionResult Index()
        {
            List<BlogModel> model = _blogService.Query().Take(3).ToList();
            return View(model);
        }
        public IActionResult BlogDetay(int? id)
        {

            //bu kpalı tamamen
            //if (id == null)
            //    return View("Hata", "id gereklidir");
            //List<BlogModel> model = _blogService.Query().Where(b => b.Blogid == id.Value).ToList();

            //if (model == null)
            //    return View("Hata", "Blog bulunamadı");
            //return View(model);

            ///**************bunu yeni kapattım
            if (id == null)
                return View("Hata", "id gereklidir");
           BlogModel model = _blogService.Query().SingleOrDefault(b => b.Id == id.Value);
          

            if (model == null)
                return View("Hata", "Blog bulunamadı");
            return View(model);



        }



    }
    }
  
