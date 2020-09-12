namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDisciplineToContest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contests", "DisciplineId", c => c.Int());
            CreateIndex("dbo.Contests", "DisciplineId");
            AddForeignKey("dbo.Contests", "DisciplineId", "dbo.Disciplines", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contests", "DisciplineId", "dbo.Disciplines");
            DropIndex("dbo.Contests", new[] { "DisciplineId" });
            DropColumn("dbo.Contests", "DisciplineId");
        }
    }
}
