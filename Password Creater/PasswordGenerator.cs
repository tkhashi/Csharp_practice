using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    public class PasswordGenerator
    {
        private string GetNumLetter(Random random)
        {
            return random.Next(10).ToString();
        }
    }
}
