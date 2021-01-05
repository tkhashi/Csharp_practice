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
        public string MakePassword(int count, ILetterFactory factory)
        {
            string password = string.Empty;
            for (int i = 0; i < count; i++)
            {
                Letter letter = factory.Create(random,i);
                password += letter.GetLetter();
            }
            return password;
        }
    }
}
