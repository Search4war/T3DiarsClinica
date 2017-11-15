using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using T3DiarsClinica.Models.ModuloMedicos.Objetos;

namespace T3DiarsClinica.Models.ModuloMedicos.Map
{
    public class MedicosEspecialidadMap:EntityTypeConfiguration<MedicosEspecialidad>
    {
        public MedicosEspecialidadMap()
        {
            //Table
            ToTable("MedicoEspecialiad");
            //PK
            HasKey(p => new {p.MedicoID, p.EspecialidadID});

            //Fk
            HasRequired(p => p.Medico).WithMany(p => p.MedicosEspecialidades).HasForeignKey(p => p.MedicoID);
            HasRequired(p => p.Especialidad).WithMany(p => p.MedicosEspecialidades).HasForeignKey(p => p.EspecialidadID);

        }
    }
}