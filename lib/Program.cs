using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1 {
	class Program {
		static void Main(string[] args){
            int count = 10;
            string password = MakeLowerAlphabet(count);
            Console.WriteLine(password);
        }
        private static string MakeLowerAlphabet(int count)
        {
            Random random = new Random();
            string password = string.Empty;
            for (int i = 0; i < count; i++)
            {
                int n = random.Next(97, 123);
                char c = (char)n;
                password += c.ToString();
            }
            return password;
        }
    }
}

