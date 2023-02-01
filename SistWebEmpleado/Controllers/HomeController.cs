using Microsoft.AspNetCore.Mvc;
using System;

namespace SistWebEmpleado.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido a nuestro Software de Empleados.";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }
    }
}
