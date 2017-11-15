using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T3DiarsClinica.Models.DB;
using T3DiarsClinica.Models.ModuloFarmacia.Objetos;

namespace T3DiarsClinica.Controllers
{
    public class FarmaciaController : Controller
    {
        // GET: Farmacia
        public ActionResult PresentacionCrear()
        {
            return View();
        }

        public ActionResult PresentacionGuardar(Presentacion presentacion)
        {
            var entities = new DbEntities();
            entities.Presentacions.Add(presentacion);
            entities.SaveChanges();
            var presentacionlist = entities.Presentacions.ToList();
            return View("PresentacionLista",presentacionlist);
        }

        public ActionResult PresentacionLista()
        {
            var entities = new DbEntities();
            var presentacion = entities.Presentacions.ToList();
            return View(presentacion);
        }

        public ActionResult PresentacionEliminar(int eliminarpresentacion)
        {
            var entities = new DbEntities();
            var eliminar =entities.Presentacions.FirstOrDefault(x => x.Id.Equals(eliminarpresentacion));
            entities.Presentacions.Remove(eliminar);
            entities.SaveChanges();
            var presentacionlist = entities.Presentacions.ToList();
            return View("PresentacionLista",presentacionlist);
        }

        public ActionResult PresentacionEditar(int editarpresentacion)
        {
            var entities = new DbEntities();
            var presentacioneditar = entities.Presentacions.FirstOrDefault(x => x.Id.Equals(editarpresentacion));
            return View(presentacioneditar);
        }

        public ActionResult PresentacionEditarGuardar(Presentacion presentacion)
        {
            var entities = new DbEntities();
            var presentacionlista = entities.Presentacions.ToList();
            var actualizar = entities.Presentacions.FirstOrDefault(x => x.Id.Equals(presentacion.Id));
            actualizar.NombrePresentacion = presentacion.NombrePresentacion;
            actualizar.Abreviatura = presentacion.Abreviatura;
            actualizar.Advertencias = presentacion.Advertencias;
            actualizar.FormaDeConservacion = presentacion.FormaDeConservacion;
            entities.SaveChanges();
            return View("PresentacionLista",presentacionlista);
        }
    }
}