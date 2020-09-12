namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReqs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teachers", "DisciplineId", "dbo.Disciplines");
            DropIndex("dbo.Teachers", new[] { "DisciplineId" });
            AlterColumn("dbo.Students", "Age", c => c.Int());
            AlterColumn("dbo.Teachers", "Age", c => c.Int());
            AlterColumn("dbo.Teachers", "DisciplineId", c => c.Int());
            CreateIndex("dbo.Teachers", "DisciplineId");
            AddForeignKey("dbo.Teachers", "DisciplineId", "dbo.Disciplines", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "DisciplineId", "dbo.Disciplines");
            DropIndex("dbo.Teachers", new[] { "DisciplineId" });
            AlterColumn("dbo.Teachers", "DisciplineId", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Age", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "DisciplineId");
            AddForeignKey("dbo.Teachers", "DisciplineId", "dbo.Disciplines", "Id", cascadeDelete: true);
        }
    }
}
