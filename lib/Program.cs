using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1 {
	class Program {
		static void Main(string[] args){
            int count = 10;
            string password = MakeMark(count);
            Console.WriteLine(password);
        }
        private static string MakeMark(int count){
            string[] marks = { "!","#","$","%","&","@"};
            Random random = new Random();
            string password = string.Empty;
            for (int i = 0; i < count; i++) {
                int n = random.Next(marks.Length);
                password += marks[n];
            }
            return password;
        }
    }
}

