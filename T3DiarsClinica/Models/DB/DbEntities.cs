using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using T3DiarsClinica.Models.ModuloMedicos.Map;
using T3DiarsClinica.Models.ModuloMedicos.Objetos;
using T3DiarsClinica.Models.ModuloFarmacia.Map;
using T3DiarsClinica.Models.ModuloFarmacia.Objetos;

namespace T3DiarsClinica.Models.DB
{
    public class DbEntities:DbContext
    {
        public IDbSet<Presentacion> Presentacions { get; set; }
        public IDbSet<Medico> Medicos { get; set; }
        public IDbSet<Especialidad> Especialidades { get; set; }
        public IDbSet<MedicosEspecialidad> MedicosEspecialidades { get; set; }

        public DbEntities()
        {
            Database.SetInitializer<DbEntities>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PresentacionMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new MedicoMap());
            modelBuilder.Configurations.Add(new EspecialidadMap());
            modelBuilder.Configurations.Add(new MedicosEspecialidadMap());
        }
    }
}