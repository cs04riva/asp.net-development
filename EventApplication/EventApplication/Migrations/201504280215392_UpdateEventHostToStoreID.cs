namespace EventApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEventHostToStoreID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "eventHost_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "eventHost_Id" });
            AddColumn("dbo.Events", "eventHost", c => c.String(nullable: false));
            DropColumn("dbo.Events", "eventHost_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "eventHost_Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Events", "eventHost");
            CreateIndex("dbo.Events", "eventHost_Id");
            AddForeignKey("dbo.Events", "eventHost_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
