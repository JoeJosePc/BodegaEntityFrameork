namespace BibliotecaClaseBodega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtables3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Productos", "Marca_Id", "dbo.Marca");
            DropIndex("dbo.Productos", new[] { "Marca_Id" });
            RenameColumn(table: "dbo.Productos", name: "Marca_Id", newName: "MarcaId");
            AlterColumn("dbo.Productos", "MarcaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Productos", "MarcaId");
            AddForeignKey("dbo.Productos", "MarcaId", "dbo.Marca", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "MarcaId", "dbo.Marca");
            DropIndex("dbo.Productos", new[] { "MarcaId" });
            AlterColumn("dbo.Productos", "MarcaId", c => c.Int());
            RenameColumn(table: "dbo.Productos", name: "MarcaId", newName: "Marca_Id");
            CreateIndex("dbo.Productos", "Marca_Id");
            AddForeignKey("dbo.Productos", "Marca_Id", "dbo.Marca", "Id");
        }
    }
}
