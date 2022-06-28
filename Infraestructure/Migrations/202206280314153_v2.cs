namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        PrecioVenta = c.Int(nullable: false),
                        EstaActivo = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaVencimiento = c.DateTime(nullable: false),
                        IGV = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
