namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFullDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        CommentId = c.Int(),
                        Amount = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BillId)
                .ForeignKey("dbo.Comment", t => t.BillId)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.BillId)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        BillId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        CommentDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductTypeId = c.Int(nullable: false),
                        ProductName = c.String(),
                        Price = c.Long(nullable: false),
                        Unit = c.String(),
                        Date = c.DateTime(nullable: false),
                        Image = c.String(),
                        Quantity = c.Int(nullable: false),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductType", t => t.ProductTypeId, cascadeDelete: true)
                .Index(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.ProductType",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Origin = c.String(),
                        Image = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "ProductTypeId", "dbo.ProductType");
            DropForeignKey("dbo.Bill", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Order", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Bill", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Bill", "BillId", "dbo.Comment");
            DropForeignKey("dbo.Comment", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Product", new[] { "ProductTypeId" });
            DropIndex("dbo.Order", new[] { "UserId" });
            DropIndex("dbo.Comment", new[] { "UserId" });
            DropIndex("dbo.Bill", new[] { "OrderId" });
            DropIndex("dbo.Bill", new[] { "ProductId" });
            DropIndex("dbo.Bill", new[] { "BillId" });
            DropTable("dbo.ProductType");
            DropTable("dbo.Product");
            DropTable("dbo.Order");
            DropTable("dbo.Comment");
            DropTable("dbo.Bill");
        }
    }
}
