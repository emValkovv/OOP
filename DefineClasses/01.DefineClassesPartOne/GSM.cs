using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        public static readonly GSM iPhone4S = new GSM("IPhone 4S", "Apple",
            new Battery("BL-40", 240, 5.6, BatteryTypes.Li_Poly), 
            new Display(4.5, 16000000));

        private string model;
        private string manufacturer;
        private Battery battery;
        private Display display;
        private List<Call> calls = new List<Call>();
        private decimal totalPrice;

        public GSM(string gsmModel, string mark) : base()
        {
            this.model = gsmModel;
            this.manufacturer = mark;
        }

        public GSM(string gsmModel, string mark, Battery battery)
            : this(gsmModel, mark)
        {
            this.battery = battery;
        }

        public GSM(string gsmModel, string mark, Battery battery, Display display)
            : this(gsmModel, mark)
        {
            this.battery = battery;
            this.display = display;
        }


        public string Model
        {
            get
            {
                if (String.IsNullOrEmpty(this.model))
                {
                    throw new ArgumentNullException("Invalid model");
                }
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                if (String.IsNullOrEmpty(this.model))
                {
                    throw new ArgumentNullException("Invalid model");
                }
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.calls);
            }
        }

        public void AddCall(Call call)
        {
            this.calls.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.calls.Remove(call);
        }

        public void ClearAllCalls()
        {
            this.calls.Clear();
        }

        public decimal TotalPrice(decimal pricePerMinute)
        {
            decimal allDuration = (decimal)this.calls.Select(x => x.Duration).Sum();
            return totalPrice = pricePerMinute * (allDuration / 60);
        }

        public override string ToString()
        {
            return "Model: " + this.model + Environment.NewLine
                + "Manufacturer: " + this.manufacturer + Environment.NewLine
                + "Battery: " + this.battery + Environment.NewLine
                + "Displey: " + this.display + Environment.NewLine;
        }
    }
}
