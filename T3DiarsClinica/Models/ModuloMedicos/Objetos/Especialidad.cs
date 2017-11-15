using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T3DiarsClinica.Models.ModuloMedicos.Objetos
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<MedicosEspecialidad> MedicosEspecialidades { get; set; }

       
    }
}