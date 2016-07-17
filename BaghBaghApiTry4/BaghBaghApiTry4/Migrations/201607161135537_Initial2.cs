namespace BaghBaghApiTry4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BasePlants", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BasePlants", "ImagePath");
        }
    }
}
