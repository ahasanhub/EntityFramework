namespace EF.BaiscRelationship.App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAccounts", "Id", "dbo.Students");
            DropIndex("dbo.StudentAccounts", new[] { "Id" });
            DropTable("dbo.StudentAccounts");
        }
    }
}
