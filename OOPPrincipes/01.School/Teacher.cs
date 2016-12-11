
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : Person
    {
        private List<Disciplines> disciplines = new List<Disciplines>();

        public Teacher(string name)
            : base(name)
        {

        }

        public List<Disciplines> GetList()
        {
            return new List<Disciplines>(this.disciplines);
        }

        public void AddDiscipline(Disciplines item)
        {
            disciplines.Add(item);
        }

        public void RemoveDiscipline(List<Disciplines> item, int i)
        {
            disciplines.Remove(item[i]);
        }

        public void Print()
        {
            foreach (Disciplines element in this.disciplines)
            {
                Console.WriteLine(element.Discipline);
            }
        }

    }
}