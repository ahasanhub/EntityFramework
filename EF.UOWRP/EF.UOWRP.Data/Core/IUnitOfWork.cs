using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.UOWRP.Data.Core.Repositories;

namespace EF.UOWRP.Data.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}
