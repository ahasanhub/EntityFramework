using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Relationship
{
    public class Department
    {
        public Department()
        {
            this.Courses=new HashSet<Course>();
        }
        //Primary key
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }

        //Navigation property
        public virtual ICollection<Course> Courses { get; set; }

    }
}
