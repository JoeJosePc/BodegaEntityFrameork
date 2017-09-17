namespace BibliotecaClaseBodega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtables2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "FechaVence", c => c.DateTime());
            AddColumn("dbo.Proveedor", "Contacto", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proveedor", "Contacto");
            DropColumn("dbo.Productos", "FechaVence");
        }
    }
}
