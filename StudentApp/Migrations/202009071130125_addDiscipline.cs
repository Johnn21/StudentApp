namespace StudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDiscipline : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Disciplines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Disciplines");
        }
    }
}
