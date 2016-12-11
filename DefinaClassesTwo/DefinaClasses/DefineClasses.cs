using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinaClassesTwo
{
    class DefineClasses
    {
        static void Main(string[] args)
        {
            Points3d a = new Points3d(3, 2, 1);
            Points3d b = new Points3d(5, 4, 3);
            double distance = StaticClass.Distance(a, b);
            Console.WriteLine(distance);

            Matrix<int> matrica = new Matrix<int>(3, 3);
            Matrix<int> matrica1 = new Matrix<int>(3, 3);

            Matrix<int> result = matrica + matrica1;
            Console.WriteLine(result);
            
        }
    }
}
