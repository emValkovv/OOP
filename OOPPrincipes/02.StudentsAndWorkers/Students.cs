using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Students : Human
    {

        private int grade;

        public Students(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.grade = grade;
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

        public int Grade 
        { 
            get
            {
                if (this.grade < 0 || this.grade > 12)
                {
                    throw new ArgumentException("Invalid grade");
                }
                return this.grade;
            }
        }

        public override string Name()
        {
            throw new NotImplementedException();
        }
    }
}
