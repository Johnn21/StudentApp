namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDateToGrade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grades", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Grades", "DateAdded");
        }
    }
}
