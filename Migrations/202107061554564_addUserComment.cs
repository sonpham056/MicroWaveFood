namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "UserComment", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comment", "UserComment");
        }
    }
}
