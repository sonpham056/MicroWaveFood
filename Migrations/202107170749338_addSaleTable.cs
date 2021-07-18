namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSaleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        SaleId = c.Int(nullable: false, identity: true),
                        SaleName = c.String(nullable: false, maxLength: 100),
                        SaleRate = c.Int(nullable: false),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        SaleContent = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.SaleId);
            
            AddColumn("dbo.Product", "SaleId", c => c.Int());
            AlterColumn("dbo.Bill", "Amount", c => c.Long(nullable: false));
            CreateIndex("dbo.Product", "SaleId");
            AddForeignKey("dbo.Product", "SaleId", "dbo.Sale", "SaleId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "SaleId", "dbo.Sale");
            DropIndex("dbo.Product", new[] { "SaleId" });
            AlterColumn("dbo.Bill", "Amount", c => c.Int(nullable: false));
            DropColumn("dbo.Product", "SaleId");
            DropTable("dbo.Sale");
        }
    }
}
