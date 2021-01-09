﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTranning
{
    public class Calculation
    {
        //private delegate int Function(int n);
        private int Power(int n)
        {
            return n * n;
        }
        public int Execute(int n)
        {
            //Function function = Power;
            //int ans = function(n);
            //int ans = Power(n);
            return Power(n);
            //これでも行けてしまうが、publicにPower(n)とメソッド直書きするのがよくない？
            //値のさいだいにゅうもできてしまうが。。
        }
    }
}
