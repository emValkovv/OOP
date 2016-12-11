using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Frog : Animals, ISound
    {
        private string color;

        public Frog(string name, int age, string sex, string color)
            : base(name, age, sex)
        {
            this.color = color;
        }

        public string Color 
        { 
            get
            {
                return this.color;
            }
        }

        public override void Sound()
        {
            Console.WriteLine("I'am a frog and I make - Kwak kwak"); 
        }
    }
}
