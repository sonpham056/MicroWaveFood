namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMailInfo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MailInfo", "Email");
            DropColumn("dbo.MailInfo", "PassWord");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MailInfo", "PassWord", c => c.String());
            AddColumn("dbo.MailInfo", "Email", c => c.String());
        }
    }
}
