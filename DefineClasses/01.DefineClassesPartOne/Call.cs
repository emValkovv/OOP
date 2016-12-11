namespace MobilePhone
{
    using System;
    public class Call
    {
        private DateTime dateTime;
        private string contact;
        private double duration;

        public Call(DateTime dateTime, string contact, double duration)
        {
            this.dateTime = dateTime;
            this.contact = contact;
            this.duration = duration;
        }

        public DateTime CallDate
        {
            get
            {
                if (this.dateTime.Equals(null))
                {
                    throw new ArgumentException("Invalid date and time");
                }
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }

        public string Contact
        {
            get
            {
                if (this.contact.Equals(null))
                {
                    throw new ArgumentException("Invalid contact");
                }
                return this.contact;
            }
            set
            {
                this.contact = value;
            }
        }

        public double Duration
        {
            get
            {
                if (this.duration < 0)
                {
                    throw new ArgumentException("Invalid duration");
                }
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return "Date and time: " + this.dateTime;
        }

    }
}
