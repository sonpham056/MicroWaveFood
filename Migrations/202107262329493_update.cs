namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.MailInfo");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MailInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        To = c.String(),
                        Subject = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
