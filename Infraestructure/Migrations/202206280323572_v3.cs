namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "PrecioVenta", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "IGV", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "IGV", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "PrecioVenta", c => c.Int(nullable: false));
        }
    }
}
