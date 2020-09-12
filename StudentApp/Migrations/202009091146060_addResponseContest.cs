namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addResponseContest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContestResponses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Body = c.String(),
                        TeacherId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContestResponses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.ContestResponses", "StudentId", "dbo.Students");
            DropIndex("dbo.ContestResponses", new[] { "StudentId" });
            DropIndex("dbo.ContestResponses", new[] { "TeacherId" });
            DropTable("dbo.ContestResponses");
        }
    }
}
