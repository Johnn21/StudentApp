namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRoleTypeFkToIdentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RoleTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "RoleTypeId");
            AddForeignKey("dbo.AspNetUsers", "RoleTypeId", "dbo.RoleTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "RoleTypeId", "dbo.RoleTypes");
            DropIndex("dbo.AspNetUsers", new[] { "RoleTypeId" });
            DropColumn("dbo.AspNetUsers", "RoleTypeId");
        }
    }
}
