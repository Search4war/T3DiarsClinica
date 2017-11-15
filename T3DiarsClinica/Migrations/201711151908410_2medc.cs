namespace T3DiarsClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2medc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medico", "TimepoTrabajo", c => c.String());
            AddColumn("dbo.Medico", "Especialidad", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medico", "Especialidad");
            DropColumn("dbo.Medico", "TimepoTrabajo");
        }
    }
}
