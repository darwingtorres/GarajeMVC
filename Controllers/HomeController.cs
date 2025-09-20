using Microsoft.AspNetCore.Mvc;
using GarajeMVC.Models;

namespace GarajeMVC.Controllers
{
    public class HomeController : Controller
    {
        // Instanciar objeto Garage
        Garage miGaraje = new Garage(1, "Darwing Alexander Torres Vaquedano", 10);

        public IActionResult Index()
        {
            // Agregar 3 autos
            miGaraje.ingresarAuto(new Auto(1, "Toyota", "P1234ABC"));
            miGaraje.ingresarAuto(new Auto(2, "Honda", "H5678DEF"));
            miGaraje.ingresarAuto(new Auto(3, "Ford", "F9012GHI"));

            // Pasar el objeto Garage a la vista
            return View(miGaraje);
        }
    }
}