using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinaClassesTwo
{
    public struct Points3d
    {
        private int x;
        private int y;
        private int z;
        private static readonly Points3d startPoint = new Points3d(0, 0, 0);

        public Points3d (int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Points3d ZeroPoint
        {
            get
            {
                return Points3d.startPoint;
            }
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetZ()
        {
            return this.z;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", this.x, this.y, this.z);
        }
    }
}
