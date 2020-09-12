namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDisciplineToGrade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grades", "DisciplineId", c => c.Int(nullable: false));
            CreateIndex("dbo.Grades", "DisciplineId");
            AddForeignKey("dbo.Grades", "DisciplineId", "dbo.Disciplines", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Grades", "DisciplineId", "dbo.Disciplines");
            DropIndex("dbo.Grades", new[] { "DisciplineId" });
            DropColumn("dbo.Grades", "DisciplineId");
        }
    }
}
