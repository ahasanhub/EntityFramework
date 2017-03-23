using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.UOWRP.Data.Core.Domain;

namespace EF.UOWRP.Data.Core.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
