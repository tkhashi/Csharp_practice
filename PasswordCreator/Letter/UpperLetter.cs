using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class UpperLetter : Letter
    {
        public UpperLetter(Random random) : base(random)
        {
        }
        public override string GetLetter()
        {
            int n;
            do {
                n = random.Next(65, 91);
            } while (n == 73 || n == 79);
            char c = (char)n;
            return c.ToString();
        }
    }
}
