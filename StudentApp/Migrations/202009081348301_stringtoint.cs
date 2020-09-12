namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringtoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Class", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Class", c => c.String());
        }
    }
}
