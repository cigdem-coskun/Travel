using AppCore.Business.Models.Results;
using Business.Models;
using Business.Service;
using Business.Service.Bases;
using DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Travel.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IBlogYorumModelService _blogYorumModelService;

        public AdminController(IBlogService blogService, IBlogYorumModelService blogYorumModelService)
        {
            _blogService = blogService;
            _blogYorumModelService = blogYorumModelService;
        }

        //[Authorize]
        public IActionResult Index()
        {
            List<BlogModel> model = _blogService.Query().ToList();
            return View(model);
        }
        public IActionResult Edit()
        {
            return View("Edit");
        }
        [HttpPost ]
        public IActionResult Edit(BlogModel blog)
        {   
            BlogModel model = new BlogModel()
            {
                Baslik = blog.Baslik,
                Aciklama = blog.Aciklama,
                Tarih = blog.Tarih,
                BlogImage = blog.BlogImage
            };
            var result = _blogService.Add(blog);
            TempData["Mesaj"] = result.Message;
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int? id)
        {
            Result result = _blogService.Delete(id.Value);
            TempData["Mesaj"] = result.Message;
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return View("Hata", "Id gereklidir!");
            BlogModel model = _blogService.Query().SingleOrDefault(kategori => kategori.Id == id);
            if (model == null)

                return View("Hata", "Blog bulunamadı");
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(BlogModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _blogService.Update(model);
                if (result.IsSuccessful)
                    return RedirectToAction(nameof(Index));
                ModelState.AddModelError("", result.Message);
            }
            return View(model);
        }
        public IActionResult YorumListesi(int page=1 )
        {
            List<BlogYorumModel> model = _blogYorumModelService.Query().ToPagedList(page,3).ToList();
            return View(model);
          
        }
        public IActionResult YorumSil(int? id)
        {
            Result result = _blogYorumModelService.Delete(id.Value);
            TempData["Mesaj"] = result.Message;
            return RedirectToAction(nameof(YorumListesi));
        }
    }
}
