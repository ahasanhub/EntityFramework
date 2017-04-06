using System.Data.Entity;
using EF.BaiscRelationship.App.Model;

namespace EF.BaiscRelationship.App.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAccount> StudentAccounts { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
