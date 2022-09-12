using Business.Models;
using Business.Service;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace Travel.Controllers
{
    public class GirisYapController : Controller
    {
        private readonly IAdminService _adminService;
        public GirisYapController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public async IActionResult Login(AdminModel ad)
        //{
        //    //AdminModel model = _adminService.Query().FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);
        //    return View();
          
        //    //return RedirectToAction("Index");
        //    //List<Claim> claims = new List<Claim>();
        //    //{
        //    //    new Claim(ClaimTypes.Name, ad.Kullanici);

        //    //};
        //    //var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //    //var principal = new ClaimsPrincipal(identity);
        //    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        //    //return RedirectToAction("Index","GirisYap");
        //    //return View(ad);
        //    //List<Claim> claims=new List<


        //    //{
        //    //    new Claim(ClaimTypes.Name, ad.Kullanici),
        //    //    new Claim(ClaimTypes.)
        //    //}
        //}
    }
}

