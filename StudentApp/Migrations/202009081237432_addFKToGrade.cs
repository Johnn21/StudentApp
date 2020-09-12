namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFKToGrade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grades", "TeacherId", c => c.Int(nullable: false));
            AddColumn("dbo.Grades", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Grades", "TeacherId");
            CreateIndex("dbo.Grades", "StudentId");
            AddForeignKey("dbo.Grades", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Grades", "TeacherId", "dbo.Teachers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Grades", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Grades", "StudentId", "dbo.Students");
            DropIndex("dbo.Grades", new[] { "StudentId" });
            DropIndex("dbo.Grades", new[] { "TeacherId" });
            DropColumn("dbo.Grades", "StudentId");
            DropColumn("dbo.Grades", "TeacherId");
        }
    }
}
