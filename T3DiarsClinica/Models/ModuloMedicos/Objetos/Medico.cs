using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T3DiarsClinica.Models.ModuloMedicos.Objetos
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Sexo { get; set; }
        public string E_Mail { get; set; }
        public string NombreUniversidad { get; set; }
        public string TimepoTrabajo { get; set; }
        public string Especialidad { get; set; }
        public string NumeroCPM { get; set; }
        public string Cargo { get; set; }
        public string LugarTrabajo { get; set; }
        public string Direccion { get; set; }
        public string HoraTrabajoDia { get; set; }

        public List<MedicosEspecialidad> MedicosEspecialidades { get; set; }     
    }
}