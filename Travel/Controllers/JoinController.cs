using Business.Models;
using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class JoinController : Controller
    {
        private readonly IJoinService _joinService;

        public JoinController(IJoinService _joinService)
        {
            this._joinService = _joinService;
        }

        public IActionResult Index(int? id)
        {
            if (id == null)
                return View("id gereklidir");
            List<joinModel> model = _joinService.Query().Where(b => b.Blogid == id.Value).ToList();

            if (model == null)
                return View("Yorum bulunamadı");
            return View(model);



        }

        public PartialViewResult Yorum(int a)
        {
            ViewBag.mesaj= a;
            return PartialView();

        }

        [HttpPost]
        public PartialViewResult Yorum(joinModel yorum)
        {
            joinModel model = new joinModel()
            { KullaniciAdi= yorum.KullaniciAdi,
             Mail= yorum.Mail,
              YapilanYorum= yorum.YapilanYorum,
                Blogid = yorum.Blogid

            };
            var result = _joinService.Add(yorum);
            //TempData["Mesaj"] = result.Message;
           
            return PartialView();
            ViewData["Mesaj"] = "Yorum yapıldı...";

        }
    }
}
