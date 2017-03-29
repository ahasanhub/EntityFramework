using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CI.EF.Business.Model;
using ContextIdeaData.EF.Data;

namespace CI.EF.Business.Data
{
    public class BookContext : CiDbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
