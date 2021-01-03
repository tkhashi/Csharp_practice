using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace make_password
{
    class Program
    {
        static void Main(string[] args){
            int count = 12;
            Random random = new Random();
            string password = MakePassword(random, count);
            Console.WriteLine(password);
            Console.ReadKey();
        }
        private static string MakePassword(Random random, int count){
            string password = string.Empty;
            for(int i = 0; i < count; i++){
                int n = i % 4;
                if(n == 0){
                    password += GetNumLetter(random);
                }
                if(n == 1){
                    password += GetUpperLetter(random);
                }
                if(n == 2){
                    password += GetLowerLetter(random);
                }
                if(n == 3){
                    password += GetMarkLetter(random);
                }
            }
            return password;
        }
        private static string GetNumLetter(Random random){
            return random.Next(10).ToString();
        }
        private static string GetLowerLetter(Random random){
            char c = (char)random.Next(97, 123);
            return c.ToString();
        }
        private static string GetUpperLetter(Random random){
            char c = (char)random.Next(65, 91);
            return c.ToString();
        }
        private static string GetMarkLetter(Random random){
            string[] mark = {"!","#","$","%","&","@"};
            int n = random.Next(mark.Length);
            return mark[n];
        }
    }
}
