using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace make_password
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static string GetNumLetter(Random random){
            return random.Next(10).ToString();
        }
    }
}
