using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Student
    {
        public string Name { get; set; }
        public string RA { get; set; }
        public string Class { get; set; }
        public string Course { get; set; }

        public Student(string name, string rA, string @class, string course)
        {
            Name = name;
            RA = rA;
            Class = @class;
            Course = course;
        }
    }
}
