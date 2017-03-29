using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Relationship
{
    public class Student
    {
        public Student() { }

        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual StudentAddress Address { get; set; }
    }
}
