using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.BaiscRelationship.App.Model;

namespace EF.BaiscRelationship.App.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAccount> StudentAccounts { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}
