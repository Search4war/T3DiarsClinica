using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T3DiarsClinica.Models.ModuloFarmacia.Objetos
{
    public class Presentacion
    {
        public int Id { get; set; }
        public string NombrePresentacion { get; set; }
        public string Abreviatura { get; set; }
        public string Advertencias { get; set; }
        public string FormaDeConservacion { get; set; }
    }
}