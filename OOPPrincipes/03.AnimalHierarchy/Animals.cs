using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animals : ISound
    {
        private string name;
        private int age;
        private string sex;

        public Animals(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Age
        {
            get
            {
                if (this.age < 0)
                {
                    throw new ArgumentException("Invalid age");
                }
                return this.age;
            }
        }

        public virtual string Sex
        {
            get
            {
                return this.sex;
            }
        }


        public virtual void Sound()
        {
            Console.WriteLine("I am an animal, but i don't know what kind of animal");
        }
    }
}
