using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T3DiarsClinica.Models.ModuloMedicos.Objetos
{
    public class MedicosEspecialidad
    {
        public int MedicoID { get; set; }
        public Medico Medico { get; set; }

        public int EspecialidadID { get; set; }
        public Especialidad Especialidad { get; set; }  
    }
}