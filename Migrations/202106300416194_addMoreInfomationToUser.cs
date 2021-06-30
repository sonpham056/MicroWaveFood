namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoreInfomationToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Province", c => c.String());
            AddColumn("dbo.AspNetUsers", "District", c => c.String());
            AddColumn("dbo.AspNetUsers", "Guild", c => c.String(maxLength: 255));
            AddColumn("dbo.AspNetUsers", "Address", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "Guild");
            DropColumn("dbo.AspNetUsers", "District");
            DropColumn("dbo.AspNetUsers", "Province");
        }
    }
}
