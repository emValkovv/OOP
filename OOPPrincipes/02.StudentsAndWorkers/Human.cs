using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        protected string firstName;
        protected string lastName;

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName 
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

        public string LastName 
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

        public abstract string Name();
    }
}
