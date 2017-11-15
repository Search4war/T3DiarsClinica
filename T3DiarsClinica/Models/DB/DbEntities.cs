using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using T3DiarsClinica.Models.ModuloFarmacia.Map;
using T3DiarsClinica.Models.ModuloFarmacia.Objetos;

namespace T3DiarsClinica.Models.DB
{
    public class DbEntities:DbContext
    {
        public IDbSet<Presentacion> Presentacions { get; set; }

        public DbEntities()
        {
            Database.SetInitializer<DbEntities>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PresentacionMap());
        }
    }
}