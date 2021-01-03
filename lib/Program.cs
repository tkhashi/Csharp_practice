using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			string password = string.Empty;
			for (int i=0; i < 10; i++){
				password += random.Next(10);
            }
			Console.WriteLine(password);
			//string message = "C#の世界へようこそ";
			//Console.WriteLine(message);
		}
	}
}
