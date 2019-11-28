﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Animal
{
    public class Shark : IAnimal
    {
        public string speak()
        {
            return "Cannot Speak";
        }
    }
}
