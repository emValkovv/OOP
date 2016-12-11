using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : Person
    {
        private int classNumber;
        private string classInSchool;

        public Student(string name, int classNumber, string classInSchool) : base(name)
        {
            this.classNumber = classNumber;
            this.classInSchool = classInSchool;
        }
    }
}
