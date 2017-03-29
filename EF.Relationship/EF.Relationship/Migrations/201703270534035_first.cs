namespace EF.Relationship.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Credits = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        Administrator = c.Int(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        InstructorId = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.InstructorId);
            
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        InstructorId = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Instructor_InstructorId = c.Int(),
                    })
                .PrimaryKey(t => t.InstructorId)
                .ForeignKey("dbo.Instructors", t => t.Instructor_InstructorId)
                .Index(t => t.Instructor_InstructorId);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Zipcode = c.Int(nullable: false),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.InstructorCourses",
                c => new
                    {
                        Instructor_InstructorId = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Instructor_InstructorId, t.Course_CourseId })
                .ForeignKey("dbo.Instructors", t => t.Instructor_InstructorId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId, cascadeDelete: true)
                .Index(t => t.Instructor_InstructorId)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.OfficeAssignments", "Instructor_InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.InstructorCourses", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.InstructorCourses", "Instructor_InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.InstructorCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.InstructorCourses", new[] { "Instructor_InstructorId" });
            DropIndex("dbo.StudentAddresses", new[] { "StudentId" });
            DropIndex("dbo.OfficeAssignments", new[] { "Instructor_InstructorId" });
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropTable("dbo.InstructorCourses");
            DropTable("dbo.Students");
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.OfficeAssignments");
            DropTable("dbo.Instructors");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
        }
    }
}
