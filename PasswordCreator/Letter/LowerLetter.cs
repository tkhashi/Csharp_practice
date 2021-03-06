﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class LowerLetter : Letter
    {
        public LowerLetter(Random random) : base(random) { }
        public override string GetLetter()
        {
            string[] lowers = Enumerable.Range(97, 26).Where(x => x != 108)
                .Select(x => ((char)x).ToString()).ToArray();
            int n = random.Next(lowers.Length);
            return lowers[n];
        }
    }
}
