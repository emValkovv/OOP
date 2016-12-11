using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Workers : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        public Workers(string firstName, string lastName, double weekSalary)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = 8;
        }

        new public string FirstName
        {
            get
            {
                if (this.firstName.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }
                return this.firstName;
            }
        }

        new public string LastName
        {
            get
            {
                if (this.lastName.Length < 3)
                {
                    throw new ArgumentException("Invalid lastname");
                }
                return this.lastName;
            }
        }

        public double WeekSalary
        {
            get
            {
                if (this.weekSalary < 0)
                {
                    throw new ArgumentException("invalid week salary");
                }
                return this.weekSalary;
            }
            set
            {
                if (this.weekSalary < 0)
                {
                    throw new ArgumentException("invalid week salary");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                if (this.workHoursPerDay < 0)
                {
                    throw new ArgumentException("invalid week salary");
                }
                return this.workHoursPerDay;
            }
            set
            {
                if (this.workHoursPerDay < 0)
                {
                    throw new ArgumentException("invalid week salary");
                }
                this.workHoursPerDay = (int)value;
            }
        }

        public int MoneyPerHour()
        {
            double salaryPerDay = this.weekSalary / 5;
            double money = salaryPerDay / this.workHoursPerDay;
            return (int)money;

        }

        public override string Name()
        {
            throw new NotImplementedException();
        }
    }
}
