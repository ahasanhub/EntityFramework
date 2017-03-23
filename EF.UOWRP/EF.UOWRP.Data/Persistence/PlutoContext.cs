using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.UOWRP.Data.Core.Domain;
using EF.UOWRP.Data.Persistence.EntityConfigurations;

namespace EF.UOWRP.Data.Persistence
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
