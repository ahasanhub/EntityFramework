using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Relationship
{
    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configura StudentId as primary key for StudentAddress.
            modelBuilder.Entity<StudentAddress>().HasKey(sa=>sa.StudentId);
            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<Student>()
                        .HasOptional(s => s.Address)
                        .WithRequired(ad => ad.Student);
            // Configure the primary key for the OfficeAssignment 
            modelBuilder.Entity<OfficeAssignment>()
                .HasKey(t => t.InstructorId);

            // Map one-to-zero or one relationship 
            modelBuilder.Entity<OfficeAssignment>()
                .HasRequired(t => t.Instructor)
                .WithOptional(t => t.OfficeAssignment);
            modelBuilder.Entity<Course>()
                .HasMany(t => t.Instructors)
                .WithMany(t => t.Courses)
                .Map(m =>
                {
                    m.ToTable("CourseInstructor");
                    m.MapLeftKey("CourseID");
                    m.MapRightKey("InstructorID");
                });

            base.OnModelCreating(modelBuilder);

        }
    }
}
