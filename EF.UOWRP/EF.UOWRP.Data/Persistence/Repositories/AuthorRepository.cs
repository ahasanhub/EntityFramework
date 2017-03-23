using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.UOWRP.Data.Core.Domain;
using EF.UOWRP.Data.Core.Repositories;

namespace EF.UOWRP.Data.Persistence.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(PlutoContext context): base(context)
        {
            
        }
        public PlutoContext PlutoContext=>Context as PlutoContext;
        public Author GetAuthorWithCourses(int id)
        {
            return PlutoContext.Authors.Include(a => a.Courses).SingleOrDefault(a => a.Id == id);
        }
    }
}
