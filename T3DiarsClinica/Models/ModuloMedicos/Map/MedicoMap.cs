using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using T3DiarsClinica.Models.ModuloMedicos.Objetos;

namespace T3DiarsClinica.Models.ModuloMedicos.Map
{
    public class MedicoMap:EntityTypeConfiguration<Medico>
    {
        public MedicoMap()
        {
            //Table
            ToTable("Medico");
            //Pk
            HasKey(p => p.Id);
            //Properties
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p=>p.Nombre).HasMaxLength(100);
            Property(p => p.ApellidoPaterno).HasMaxLength(100);
            Property(p => p.ApellidoMaterno).HasMaxLength(100);
            Property(p => p.Dni).HasMaxLength(8);
            Property(p => p.E_Mail).HasMaxLength(20);
            Property(p => p.NombreUniversidad).HasMaxLength(50);
            Property(p => p.NumeroCPM).HasMaxLength(15);
            Property(p => p.Cargo).HasMaxLength(100);
            Property(p => p.LugarTrabajo).HasMaxLength(200);
            Property(p => p.Direccion).HasMaxLength(300);
            
        }
    }
}