using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using T3DiarsClinica.Models.ModuloMedicos.Objetos;

namespace T3DiarsClinica.Models.ModuloMedicos.Map
{
    public class EspecialidadMap:EntityTypeConfiguration<Especialidad>
    {
        public EspecialidadMap()
        {
            //Table
            ToTable("Especialidad");
            //Pk
            HasKey(p => p.Id);
            //Properties
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nombre).HasMaxLength(50);
            
        }
    }
}