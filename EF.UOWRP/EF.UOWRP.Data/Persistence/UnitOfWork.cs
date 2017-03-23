using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.UOWRP.Data.Core;
using EF.UOWRP.Data.Core.Repositories;
using EF.UOWRP.Data.Persistence.Repositories;

namespace EF.UOWRP.Data.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            Courses=new CourseRepository(context);
            Authors=new AuthorRepository(context);
        }
        public ICourseRepository Courses { get; private set; }
        public IAuthorRepository Authors { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
