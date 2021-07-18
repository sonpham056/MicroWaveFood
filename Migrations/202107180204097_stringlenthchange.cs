namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringlenthchange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comment", "UserComment", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Product", "ProductDescribe", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Sale", "SaleContent", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sale", "SaleContent", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Product", "ProductDescribe", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Comment", "UserComment", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
