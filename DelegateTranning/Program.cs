using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTranning
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculation = new Calculation();
            int ans = calculation.Execute(7);
            Console.WriteLine(ans);
            int ans2 = calculation.Execute(9);
            Console.WriteLine(ans2);
        }
    }
}
