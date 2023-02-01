using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {

        private readonly DBEmpleadosContext context;

        public EmpleadoController(DBEmpleadosContext context)
        {
            this.context = context;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
           
            var empleados = context.Empleados.ToList();

            
            return View(empleados);
        }

        
        [HttpGet]
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View("Create", empleado);
        }

        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Empleado empleado = context.Empleados.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", empleado);
            }
        }

        
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = TraerUno(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                context.Empleados.Remove(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

       
        [HttpGet]
        public ActionResult Details(int id)
        {
            var empleado = TraerUno(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {

                return View("Details", empleado);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Empleado empleado = TraerUno(id);
            return View("Edit", empleado);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(int id, Empleado empleado)
        {
            if (id != empleado.Id)
            {
                return NotFound();
            }
            else
            {
                context.Entry(empleado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet("{titulo}")]
        public ActionResult<Empleado> GetByTitulo(string titulo)
        {

            List<Empleado> empleados = (from e in context.Empleados
                                        where e.Título == titulo
                                        select e).ToList();
            return View("GetByTitulo", empleados);
        }

        private Empleado TraerUno(int id)
        {
            return context.Empleados.Find(id);
        }
    }

}
