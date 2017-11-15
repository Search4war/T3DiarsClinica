using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using T3DiarsClinica.Models.ModuloFarmacia.Objetos;

namespace T3DiarsClinica.Models.ModuloFarmacia.Map
{
    public class PresentacionMap:EntityTypeConfiguration<Presentacion>
    {
        public PresentacionMap()
        {
            //tabla
            ToTable("Presentacion");

            //key
            HasKey(x=>x.Id);

            //properties
            Property(x => x.Abreviatura).HasMaxLength(50).IsRequired();
            Property(x => x.Advertencias).HasMaxLength(250).IsRequired();
            Property(x => x.NombrePresentacion).HasMaxLength(250).IsRequired();
            Property(x => x.FormaDeConservacion).HasMaxLength(250).IsOptional();
        }
    }
}