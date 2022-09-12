using Business.Models;
using Business.Service.Bases;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class HakkimizdaController : Controller
    {

        private readonly IHakkimizdaService _hakkimizdaService;

        public HakkimizdaController(IHakkimizdaService hakkimizdaService)
        {
            _hakkimizdaService = hakkimizdaService;
        }

        public IActionResult Index()
        {
            List <HakkimizdaModel> model = _hakkimizdaService.Query().ToList();
            return View(model);
     
        }
    }
}
