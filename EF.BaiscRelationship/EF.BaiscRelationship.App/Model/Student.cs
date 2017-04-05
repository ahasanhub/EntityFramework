using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.BaiscRelationship.App.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual StudentAccount StudentAccount { get; set; }
        public ICollection<StudentAddress> StudentAddresses { get; set; }
    }
    public class StudentAccount
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        [Required]
        public virtual Student Student { get; set; }

    }
    public class StudentAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
