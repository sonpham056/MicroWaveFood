namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProductDescribeToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ProductDescribe", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ProductDescribe");
        }
    }
}
