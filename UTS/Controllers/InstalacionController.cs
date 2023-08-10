using Microsoft.AspNetCore.Mvc;
using UTS.Datos;
using UTS.Models;

namespace UTS.Controllers
{
    public class InstalacionController : Controller
    {
        InstalacionDatos _instalacionDatos = new InstalacionDatos();
        public IActionResult Listar()
        {
            var lista = _instalacionDatos.Lista();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Insertar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insertar(InstalacionModel model)
        {
            var respuesta = _instalacionDatos.GuardarInstalacion(model);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }
    }
}
