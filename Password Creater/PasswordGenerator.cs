using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    public class PasswordGenerator {
        private Random random;
        public PasswordGenerator(Random random) {
            this.random = random;
        }
        public string MakePassword(int count)
        {

            string password = string.Empty;
            for(int i = 0 ; i<count; i++){
                int n = i % 4;
                if (n == 0) password += GetNumLetter();
                if (n == 1) password += GetLowerLetter();
                if (n == 2) password += GetUpperLetter();
                if (n == 3) password += GetMarkLetter();
            }
            return password;
        }
        private string GetNumLetter() {
            return random.Next(10).ToString();
        }
        private string GetLowerLetter() {
            char c = (char)random.Next(97, 123);
            return c.ToString();
        }
        private string GetUpperLetter() {
            char c = (char)random.Next(65, 91);
            return c.ToString();
        }
        private string GetMarkLetter() {
            string[] mark = { "!", "#", "$", "%", "&", "@" };
            int n = random.Next(mark.Length);
            return mark[n];
        }
    }
}
