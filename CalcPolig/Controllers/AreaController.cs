using CalcPolig.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalcPolig.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(AreaModel model)
        {
            model.Resultado = (model.Base * model.Altura) / 2;

            return View("Index", model);
        }
    }
}