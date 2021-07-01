namespace MicroWaveFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsDeliveredToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "IsDelivered", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Order", "IsDelivered");
        }
    }
}
