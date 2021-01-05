using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    public class Shuffle
    {
        public string Exceute(string password)
        {
            char x = ' ';
            string res = string.Empty;
            int c = 0;
            char[] pws = password.ToArray();
            Random random = new Random();
            while(c < password.Length)
            {
                int n = random.Next(password.Length);
                if (pws[n] != x)
                {
                    res += pws[n];
                    pws[n] = x;
                    c++;
                }
            }
            return res;
        }
    }
}
