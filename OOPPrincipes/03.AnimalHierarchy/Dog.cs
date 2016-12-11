using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Dog : Animals, ISound
    {
        private string breed;

        public Dog(string name, int age, string sex, string breed)
            : base(name, age, sex)
        {
            this.breed = breed;
        }

        public string Breed 
        { 
            get
            {
                if (this.breed.Length < 3)
                {
                    throw new ArgumentException("Invalid breed");
                }
                return this.breed;
            }
        }

        public override void Sound()
        {
            Console.WriteLine("I'am a dog and I make - Woof woof"); 
        }

    }
}
