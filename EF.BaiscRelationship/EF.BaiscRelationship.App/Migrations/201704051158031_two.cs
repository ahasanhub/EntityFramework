namespace EF.BaiscRelationship.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "StudentId" });
            DropTable("dbo.StudentAddresses");
        }
    }
}
