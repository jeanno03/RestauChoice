namespace RestauChoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restaurants", "Adresse", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurants", "Adresse", c => c.String(nullable: false));
        }
    }
}
