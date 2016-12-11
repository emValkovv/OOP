using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Battery
    {
        private BatteryTypes batterytype;
        private string model;
        private double hoursIdle;
        private double hoursTalk;

        public Battery(string model, double timeIdle, double timeTalk, BatteryTypes batterytype)
        {
            this.model = model;
            this.hoursIdle = timeIdle;
            this.hoursTalk = timeTalk;
            this.batterytype = batterytype;
        }

        public string Model { get; private set; }

        public double HoursIdle
        {
            get
            {
                if (hoursIdle <=0)
                {
                    throw new ArgumentException("Invalid hours");
                }
                return this.hoursIdle;
            }
            private set
            {
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                if (hoursTalk <= 0)
                {
                    throw new ArgumentException("Invalid hours");
                }
                return this.hoursTalk;
            }
            private set
            {
                this.hoursTalk = value;
            }
        }
        public override string ToString()
        {
            return this.model + ", Idle hours: " + this.hoursIdle + ", Talk hours: " + this.hoursTalk + ", Type: " + this.batterytype; 
        }

    }

    public enum BatteryTypes
    {
        Li_Ion,
        Li_Poly,
        NiMH,
        NiCd
    }
}

