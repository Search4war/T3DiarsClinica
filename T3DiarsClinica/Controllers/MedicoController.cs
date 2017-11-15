using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T3DiarsClinica.Models.DB;
using T3DiarsClinica.Models.ModuloMedicos.Objetos;

namespace T3DiarsClinica.Controllers
{
    public class MedicoController : Controller
    {
        // GET: Medico
        public ActionResult ListarMedico()
        {
            var entities = new DbEntities();
            var medicos = entities.Medicos.Include("MedicosEspecialidades.Especialidad")
                .ToList();
            return View(medicos);
        }

        public ActionResult CrearMedico()
        {
            var entities = new DbEntities();
            ViewBag.especialidades = entities.Especialidades.ToList();

            return View(new Medico());
        }

        public ActionResult GuardarMedico(Medico medico, List<int> especialidadIDS)
        {

            var entities = new DbEntities();
            entities.Medicos.Add(medico);
            entities.SaveChanges();

            //
            foreach (var mascotaidcar in especialidadIDS)
            {
                var mas = new MedicosEspecialidad();
                mas.EspecialidadID = mascotaidcar;
                mas.MedicoID = medico.Id;
                entities.MedicosEspecialidades.Add(mas);
                entities.SaveChanges();
            }
            //ViewBag.especialidades = entities.Medicos.ToList();
            return RedirectToAction("ListarMedico");
        }

        public ActionResult EliminarMedico(int eliminarmedic)
        {
            var entities = new DbEntities();
            var eliminarmedico = entities.Medicos.FirstOrDefault(p => p.Id.Equals(eliminarmedic));
            var eliminarespecialidades =
                entities.MedicosEspecialidades.FirstOrDefault(p => p.MedicoID.Equals(eliminarmedic));
            entities.MedicosEspecialidades.Remove(eliminarespecialidades);
            entities.Medicos.Remove(eliminarmedico);
            entities.SaveChanges();

            return RedirectToAction("ListarMedico");
        }

        public ActionResult ListarEspecialidad()
        {
            var entities = new DbEntities();
            var especialidades = entities.Especialidades.ToList();
            return View(especialidades);
        }

        public ActionResult CrearEspecialidad()
        {
            var entities = new DbEntities();
            var especialidades = entities.Especialidades.ToList();

            return View(especialidades);
        }

        public ActionResult GuardarEspecialidad(Especialidad especialidad)
        {
            var entities = new DbEntities();
            EjecutarValidacionesEspecialidades(especialidad);
            if (ModelState.IsValid)
            {
                entities.Especialidades.Add(especialidad);
                entities.SaveChanges();
                return RedirectToAction("ListarEspecialidad");
            }

            return View("CrearEspecialidad", especialidad);
        }

        public ActionResult EliminarEspecialidad(int eliminaespecialidad)
        {
            var entities = new DbEntities();
            var eliminespecialidad = entities.Especialidades.FirstOrDefault(p => p.Id.Equals(eliminaespecialidad));
            entities.Especialidades.Remove(eliminespecialidad);
            entities.SaveChanges();

            return RedirectToAction("ListarEspecialidad");
        }

        private void EjecutarValidacionesEspecialidades(Especialidad e)
        {
            if (string.IsNullOrEmpty(e.Nombre))
                ModelState.AddModelError("Nombre", "Nombre es obligatorio");
        }
        public ViewResult EditarEspecialidad(int Idsespecialidad)
        {
            var entities = new DbEntities();
            var e = entities.Especialidades.Where(o => o.Id == Idsespecialidad).FirstOrDefault();
            ViewBag.especialidadess = entities.Especialidades.ToList();
            return View(e);
        }
        public ActionResult ActualizarEspecialidad(Especialidad e)
        {
            EjecutarValidacionesEspecialidades(e);
            var entities = new DbEntities();
            if (ModelState.IsValid)
            {
                Especialidad esp = entities.Especialidades.Where(o => o.Id == e.Id).FirstOrDefault();
                esp.Nombre = e.Nombre;
                entities.SaveChanges();

                TempData["MENSAJE_GLOBAL"] = "La especialidad se actualizo correctamente";


                return RedirectToAction("ListarEspecialidad");
            }

            ViewBag.especialidadess = entities.Especialidades.ToList();
            return View("EditarEspecialidad", e);
        }
    }
}