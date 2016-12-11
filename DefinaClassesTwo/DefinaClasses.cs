using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinaClassesTwo
{
    class DefinaClasses
    {
        static void Main(string[] args)
        {
            Points3d a = new Points3d(3, 2, 1);
            Points3d b = new Points3d(5, 4, 3);
            double distance = StaticClass.Distance(a, b);
            Console.WriteLine(distance);
        }
    }
}
