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
            //ILetterFactory型の引数factoryにAllLetterFactoryクラスのインスタンスを格納すると記号を含む、
            //NonMarkLetterFactoryクラスのインスタンスを格納すれば記号を含まない
            //ILetterFactory型の引数factoryにがとなる。
            ILetterFactory factory = new AllLetterFactory();
            PasswordGenerator generator = new PasswordGenerator(random);
            string password = generator.MakePassword(count, factory);
            Console.WriteLine(password);
            Console.ReadKey();
        }
    }
}
