using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animals, ISound
    {
        public Cat(string name, int age, string sex, string color) : base(name, age, sex)
        {
        }

    }
}
