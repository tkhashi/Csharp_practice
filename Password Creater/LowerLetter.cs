using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    public class LowerLetter : Letter
    {
        public LowerLetter(Random random) : base(random)
        {
        }
        public override string GetLetter()
        {
            char c = (char)random.Next(97, 123);
            return c.ToString();
        }
    }
}
