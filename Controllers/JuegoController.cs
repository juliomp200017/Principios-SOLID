using Microsoft.AspNetCore.Mvc;
using Solid.Models;

namespace Solid.Controllers
{
    public class JuegoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(Juego juego)
        {
            if (!ModelState.IsValid)
            {
                return View(juego);
            }
            //Guardado BD


            //Guardado en Log

             

            return Ok();
        }
    }
}
