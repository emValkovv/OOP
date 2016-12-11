
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Class
    {
        private string classId;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();

        public Class(string classId)
        {
            this.classId = classId;
        }

        public List<Teacher> GetList()
        {
            return new List<Teacher>(this.teachers);
        }

        public List<Student> GetList()
        {
            return new List<Student>(this.students);
        }

        public void AddStudent(Student item)
        {
            students.Add(item);
        }

        public void RemoveStudent(List<Student> item, int classNumber)
        {
            students.Remove(item[classNumber]);
        }

        public void AddTeacher(Teacher item)
        {
            teachers.Add(item);
        }

        public void RemoveTeacher(List<Teacher> item, int teacher)
        {
            teachers.Remove(item[teacher]);
        }

    }
}
