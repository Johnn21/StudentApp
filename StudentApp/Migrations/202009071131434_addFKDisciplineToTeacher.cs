namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFKDisciplineToTeacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "DisciplineId", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "DisciplineId");
            AddForeignKey("dbo.Teachers", "DisciplineId", "dbo.Disciplines", "Id", cascadeDelete: true);
            DropColumn("dbo.Teachers", "Discipline");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Discipline", c => c.String());
            DropForeignKey("dbo.Teachers", "DisciplineId", "dbo.Disciplines");
            DropIndex("dbo.Teachers", new[] { "DisciplineId" });
            DropColumn("dbo.Teachers", "DisciplineId");
        }
    }
}
