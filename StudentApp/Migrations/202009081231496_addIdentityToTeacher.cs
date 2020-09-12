namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIdentityToTeacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "IdentityUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Teachers", "IdentityUserId");
            AddForeignKey("dbo.Teachers", "IdentityUserId", "dbo.IdentityUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "IdentityUserId", "dbo.IdentityUsers");
            DropIndex("dbo.Teachers", new[] { "IdentityUserId" });
            DropColumn("dbo.Teachers", "IdentityUserId");
        }
    }
}
