﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    public class NumLetter : Letter
    {
        public NumLetter(Random random) : base(random)
        {
        }
        public override string GetLetter()
        {
            return random.Next(10).ToString();
        }
    }
}
