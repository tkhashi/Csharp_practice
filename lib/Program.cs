using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1 {
	class Program {
		static void Main(string[] args) {
			int count = 14;
			string password = MakePassword(count);
            Console.WriteLine(password);
        }
		private static string MakePassword(int count) {
			Random random = new Random();
			string password = string.Empty;
			for (int i=0; i < count; i++){
				password += random.Next(10);
            }
			return password;
        }
			//Console.WriteLine(password);
			//string message = "C#の世界へようこそ";
			//Console.WriteLine(message);
    }
}

