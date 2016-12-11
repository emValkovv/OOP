using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Disciplines
    {
        private string nameOfDiscipline;
        private int lectures;
        private int exercises;

        public Disciplines(string nameOfDiscipline, int lectures, int exercises)
        {
            this.nameOfDiscipline = nameOfDiscipline;
            this.lectures = lectures;
            this.exercises = exercises;
        }

        public string Discipline
        {
            get
            {
                return this.nameOfDiscipline;
            }
        }

        public int Lectures
        {
            get
            {
                if (this.lectures < 0)
                {
                    throw new ArgumentException("Invalid numbers of lectures");
                }
                return this.lectures;
            }
            set
            {
                if (this.lectures < 0)
                {
                    throw new ArgumentException("Invalid numbers of lectures");
                }
                this.lectures = value;
            }
        }

        public int Exercises
        {
            get
            {
                if (this.exercises < 0)
                {
                    throw new ArgumentException("Invalid numbers of lectures");
                }
                return this.exercises;
            }
            set
            {
                if (this.exercises < 0)
                {
                    throw new ArgumentException("Invalid numbers of lectures");
                }
                this.exercises = value;
            }

        }
    }
}
