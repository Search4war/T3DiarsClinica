namespace T3DiarsClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class medicosespe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Especialidad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MedicoEspecialiad",
                c => new
                    {
                        MedicoID = c.Int(nullable: false),
                        EspecialidadID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MedicoID, t.EspecialidadID })
                .ForeignKey("dbo.Especialidad", t => t.EspecialidadID, cascadeDelete: true)
                .ForeignKey("dbo.Medico", t => t.MedicoID, cascadeDelete: true)
                .Index(t => t.MedicoID)
                .Index(t => t.EspecialidadID);
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        ApellidoPaterno = c.String(maxLength: 100),
                        ApellidoMaterno = c.String(maxLength: 100),
                        Dni = c.String(maxLength: 8),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Sexo = c.Boolean(nullable: false),
                        E_Mail = c.String(maxLength: 20),
                        NombreUniversidad = c.String(maxLength: 50),
                        NumeroCPM = c.String(maxLength: 15),
                        Cargo = c.String(maxLength: 100),
                        LugarTrabajo = c.String(maxLength: 200),
                        Direccion = c.String(maxLength: 300),
                        HoraTrabajoDia = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MedicoEspecialiad", "MedicoID", "dbo.Medico");
            DropForeignKey("dbo.MedicoEspecialiad", "EspecialidadID", "dbo.Especialidad");
            DropIndex("dbo.MedicoEspecialiad", new[] { "EspecialidadID" });
            DropIndex("dbo.MedicoEspecialiad", new[] { "MedicoID" });
            DropTable("dbo.Medico");
            DropTable("dbo.MedicoEspecialiad");
            DropTable("dbo.Especialidad");
        }
    }
}
