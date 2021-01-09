using System;
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
        private int GetDouble(int n)
        {
            return n * 2;
        }
        public int Execute(int n)
        {
            Func<int, int> function = GetDouble;
            //Function function = GetDouble;
            int ans = function(n);
            return ans;
        }
    }
}
