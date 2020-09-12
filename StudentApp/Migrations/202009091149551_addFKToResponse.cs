namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFKToResponse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContestResponses", "ContestId", c => c.Int(nullable: false));
            CreateIndex("dbo.ContestResponses", "ContestId");
            AddForeignKey("dbo.ContestResponses", "ContestId", "dbo.Contests", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContestResponses", "ContestId", "dbo.Contests");
            DropIndex("dbo.ContestResponses", new[] { "ContestId" });
            DropColumn("dbo.ContestResponses", "ContestId");
        }
    }
}
