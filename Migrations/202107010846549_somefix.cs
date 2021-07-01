namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somefix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bill", "BillId", "dbo.Comment");
            DropIndex("dbo.Bill", new[] { "BillId" });
            DropPrimaryKey("dbo.Bill");
            AlterColumn("dbo.Bill", "BillId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bill", "BillId");
            CreateIndex("dbo.Comment", "BillId");
            AddForeignKey("dbo.Comment", "BillId", "dbo.Bill", "BillId", cascadeDelete: true);
            DropColumn("dbo.Bill", "CommentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bill", "CommentId", c => c.Int());
            DropForeignKey("dbo.Comment", "BillId", "dbo.Bill");
            DropIndex("dbo.Comment", new[] { "BillId" });
            DropPrimaryKey("dbo.Bill");
            AlterColumn("dbo.Bill", "BillId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Bill", "BillId");
            CreateIndex("dbo.Bill", "BillId");
            AddForeignKey("dbo.Bill", "BillId", "dbo.Comment", "CommentId");
        }
    }
}
