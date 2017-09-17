namespace BibliotecaClaseBodega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        DiaDeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        DiaDeCreacion = c.DateTime(nullable: false),
                        Marca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.Marca", t => t.Marca_Id)
                .Index(t => t.CategoriaId)
                .Index(t => t.Marca_Id);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        DiaDeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proveedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        DiaDeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProveedorMarca",
                c => new
                    {
                        Proveedor_Id = c.Int(nullable: false),
                        Marca_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Proveedor_Id, t.Marca_Id })
                .ForeignKey("dbo.Proveedor", t => t.Proveedor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Marca", t => t.Marca_Id, cascadeDelete: true)
                .Index(t => t.Proveedor_Id)
                .Index(t => t.Marca_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProveedorMarca", "Marca_Id", "dbo.Marca");
            DropForeignKey("dbo.ProveedorMarca", "Proveedor_Id", "dbo.Proveedor");
            DropForeignKey("dbo.Productos", "Marca_Id", "dbo.Marca");
            DropForeignKey("dbo.Productos", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.ProveedorMarca", new[] { "Marca_Id" });
            DropIndex("dbo.ProveedorMarca", new[] { "Proveedor_Id" });
            DropIndex("dbo.Productos", new[] { "Marca_Id" });
            DropIndex("dbo.Productos", new[] { "CategoriaId" });
            DropTable("dbo.ProveedorMarca");
            DropTable("dbo.Proveedor");
            DropTable("dbo.Marca");
            DropTable("dbo.Productos");
            DropTable("dbo.Categoria");
        }
    }
}
