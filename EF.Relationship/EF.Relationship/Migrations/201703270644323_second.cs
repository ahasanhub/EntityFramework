namespace EF.Relationship.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.InstructorCourses", newName: "CourseInstructor");
            DropIndex("dbo.OfficeAssignments", new[] { "Instructor_InstructorId" });
            DropColumn("dbo.OfficeAssignments", "InstructorId");
            RenameColumn(table: "dbo.CourseInstructor", name: "Instructor_InstructorId", newName: "InstructorID");
            RenameColumn(table: "dbo.CourseInstructor", name: "Course_CourseId", newName: "CourseID");
            RenameColumn(table: "dbo.OfficeAssignments", name: "Instructor_InstructorId", newName: "InstructorId");
            RenameIndex(table: "dbo.CourseInstructor", name: "IX_Course_CourseId", newName: "IX_CourseID");
            RenameIndex(table: "dbo.CourseInstructor", name: "IX_Instructor_InstructorId", newName: "IX_InstructorID");
            DropPrimaryKey("dbo.OfficeAssignments");
            DropPrimaryKey("dbo.CourseInstructor");
            AlterColumn("dbo.OfficeAssignments", "InstructorId", c => c.Int(nullable: false));
            AlterColumn("dbo.OfficeAssignments", "InstructorId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.OfficeAssignments", "InstructorId");
            AddPrimaryKey("dbo.CourseInstructor", new[] { "CourseID", "InstructorID" });
            CreateIndex("dbo.OfficeAssignments", "InstructorId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorId" });
            DropPrimaryKey("dbo.CourseInstructor");
            DropPrimaryKey("dbo.OfficeAssignments");
            AlterColumn("dbo.OfficeAssignments", "InstructorId", c => c.Int());
            AlterColumn("dbo.OfficeAssignments", "InstructorId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CourseInstructor", new[] { "Instructor_InstructorId", "Course_CourseId" });
            AddPrimaryKey("dbo.OfficeAssignments", "InstructorId");
            RenameIndex(table: "dbo.CourseInstructor", name: "IX_InstructorID", newName: "IX_Instructor_InstructorId");
            RenameIndex(table: "dbo.CourseInstructor", name: "IX_CourseID", newName: "IX_Course_CourseId");
            RenameColumn(table: "dbo.OfficeAssignments", name: "InstructorId", newName: "Instructor_InstructorId");
            RenameColumn(table: "dbo.CourseInstructor", name: "CourseID", newName: "Course_CourseId");
            RenameColumn(table: "dbo.CourseInstructor", name: "InstructorID", newName: "Instructor_InstructorId");
            AddColumn("dbo.OfficeAssignments", "InstructorId", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.OfficeAssignments", "Instructor_InstructorId");
            RenameTable(name: "dbo.CourseInstructor", newName: "InstructorCourses");
        }
    }
}
