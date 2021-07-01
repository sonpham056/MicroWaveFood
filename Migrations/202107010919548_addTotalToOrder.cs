namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTotalToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "Total", c => c.Long());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Order", "Total");
        }
    }
}
