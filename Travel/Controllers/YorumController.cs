using Business.Models;
using Business.Service.Bases;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{


    public class YorumController : Controller
    {
        private readonly IBlogYorumModelService _blogYorumModelService;

        public YorumController(IBlogYorumModelService blogYorumModelService)
        {
            _blogYorumModelService = blogYorumModelService;
        }

        public IActionResult Index()
        {
            List<BlogYorumModel> model = _blogYorumModelService.Query().ToList();
            return View(model);

            //    List<BlogYorumModel> model = _blogYorumModelService.Query().Where(b=>b.Blogid==id).ToList();
            //    return View(model);
            //}
            //    public IActionResult Details(int? id)//burda idli kullanyoruz
            //{


            //    List<BlogYorumModel> model = _blogYorumModelService.Query().Where(b => b.Blogid == id).ToList();
            //    return View(model);
            //}

        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return View("Hata", "Id gereklidir!");
            BlogYorumModel model = _blogYorumModelService.Query().SingleOrDefault(k=> k.Id == id);
            if (model == null)

                return View("Hata", "Yorum bulunamadı");
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(BlogYorumModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _blogYorumModelService.Update(model);
                if (result.IsSuccessful)
                    return RedirectToAction(nameof(Index));
                ModelState.AddModelError("", result.Message);
            }
            return View(model);
        }
    }
    }
