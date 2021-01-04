using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int count = 12;
            PasswordGenerator generator = new PasswordGenerator(random);
            string password = generator.MakePassword(count);
            Console.WriteLine(password);
            Console.ReadKey();
        }
    }
}
