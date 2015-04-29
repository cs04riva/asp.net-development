namespace EventApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "eventHost_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Events", "eventHost_Id");
            AddForeignKey("dbo.Events", "eventHost_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "eventHost_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "eventHost_Id" });
            DropColumn("dbo.Events", "eventHost_Id");
        }
    }
}
