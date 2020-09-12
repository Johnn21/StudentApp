namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFKToContest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contests", "TeacherId", c => c.Int());
            AddColumn("dbo.Contests", "StudentId", c => c.Int());
            AddColumn("dbo.Contests", "GradeId", c => c.Int());
            CreateIndex("dbo.Contests", "TeacherId");
            CreateIndex("dbo.Contests", "StudentId");
            CreateIndex("dbo.Contests", "GradeId");
            AddForeignKey("dbo.Contests", "GradeId", "dbo.Grades", "Id");
            AddForeignKey("dbo.Contests", "StudentId", "dbo.Students", "Id");
            AddForeignKey("dbo.Contests", "TeacherId", "dbo.Teachers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contests", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Contests", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Contests", "GradeId", "dbo.Grades");
            DropIndex("dbo.Contests", new[] { "GradeId" });
            DropIndex("dbo.Contests", new[] { "StudentId" });
            DropIndex("dbo.Contests", new[] { "TeacherId" });
            DropColumn("dbo.Contests", "GradeId");
            DropColumn("dbo.Contests", "StudentId");
            DropColumn("dbo.Contests", "TeacherId");
        }
    }
}
