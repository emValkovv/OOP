﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, string sex, string color)
            : base(name, age, sex, color)
        {
        }

        public override string Sex
        {
            get
            {
            }
            set
            {
            }
        }
        


    }
}
