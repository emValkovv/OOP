using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class AnimalsProgram
    {
        static void Main()
        {

            Dog realKuche = new Dog("pesho", 7, "jensko", "labrador");
            Console.WriteLine(realKuche.Breed + " " + realKuche.Name);

            realKuche.Sound();

            
        }
    }
}
