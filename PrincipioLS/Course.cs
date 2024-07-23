using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioLS
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Limit { get; set; }

        public abstract void Subscribe(Student student);
        public abstract string Cupo();
    }
}
