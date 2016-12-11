using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Display
    {
        private double size;
        private double numberColors;

        public Display(double sizeOfDisplay, int colorsOfDisplay)
        {
            this.size = sizeOfDisplay;
            this.numberColors = colorsOfDisplay;
        }

        public double Size
        {
            get
            {
                if (size < 0 && size > 7)
                {
                    throw new ArgumentException("Invalid display size");
                }
                return this.size;
            }
            private set
            {
                this.size = value;
            }
        }

        public double NumberOfColors
        {
            get
            {
                if (numberColors < 0)
                {
                    throw new ArgumentException("Invalid display size");
                }
                return this.numberColors;
            }
            private set
            {
                this.numberColors = value;
            }
        }
        public override string ToString()
        {
            return "size: " + this.size + " inches, colors: " + this.numberColors;
        }
    }
}
