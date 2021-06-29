namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRequiredToFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "ProductName", c => c.String(nullable: false));
            AlterColumn("dbo.Product", "Unit", c => c.String(nullable: false));
            AlterColumn("dbo.Product", "Image", c => c.String(nullable: false));
            AlterColumn("dbo.Product", "Origin", c => c.String(nullable: false));
            AlterColumn("dbo.ProductType", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ProductType", "GroupType", c => c.String(nullable: false));
            AlterColumn("dbo.ProductType", "Image", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductType", "Image", c => c.String());
            AlterColumn("dbo.ProductType", "GroupType", c => c.String());
            AlterColumn("dbo.ProductType", "Name", c => c.String());
            AlterColumn("dbo.Product", "Origin", c => c.String());
            AlterColumn("dbo.Product", "Image", c => c.String());
            AlterColumn("dbo.Product", "Unit", c => c.String());
            AlterColumn("dbo.Product", "ProductName", c => c.String());
        }
    }
}
