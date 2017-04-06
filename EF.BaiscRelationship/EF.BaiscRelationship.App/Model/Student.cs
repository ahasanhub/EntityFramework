using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF.BaiscRelationship.App.Model
{
    public class Student
    {
        public Student()
        {
            StudentAddresses=new HashSet<StudentAddress>();
            Subjects = new HashSet<Subject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual StudentAccount StudentAccount { get; set; }
        public virtual ICollection<StudentAddress> StudentAddresses { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

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
    public class Subject
    {
        public Subject()
        {
            Students = new HashSet<Student>();

        }
        public int Id { get; set; }

        public string Name { get; set; }


        public virtual ICollection<Student> Students { get; set; }
        
    }
}
