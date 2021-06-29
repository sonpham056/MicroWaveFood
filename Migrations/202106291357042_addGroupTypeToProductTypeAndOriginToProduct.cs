namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGroupTypeToProductTypeAndOriginToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Origin", c => c.String());
            AddColumn("dbo.ProductType", "GroupType", c => c.String());
            DropColumn("dbo.ProductType", "Origin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductType", "Origin", c => c.String());
            DropColumn("dbo.ProductType", "GroupType");
            DropColumn("dbo.Product", "Origin");
        }
    }
}
