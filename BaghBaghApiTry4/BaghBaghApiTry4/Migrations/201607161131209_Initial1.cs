namespace BaghBaghApiTry4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BasePlants", "UserName", c => c.String());
            AddColumn("dbo.BasePlants", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BasePlants", "Email");
            DropColumn("dbo.BasePlants", "UserName");
        }
    }
}
