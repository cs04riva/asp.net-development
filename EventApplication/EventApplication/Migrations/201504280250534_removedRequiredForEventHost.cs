namespace EventApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedRequiredForEventHost : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "eventHost", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "eventHost", c => c.String(nullable: false));
        }
    }
}
