using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinaClassesTwo
{
    public static class StaticClass
    {
        public static double Distance(Points3d a, Points3d b)
        {
            double deltaX = b.GetX() - a.GetX();
            double deltaY = b.GetY() - a.GetY();
            double deltaZ = b.GetZ() - a.GetZ();
            double distance = Math.Sqrt((Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2)));
            return distance;
        }
    }
}
