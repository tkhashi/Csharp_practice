using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    public abstract class LetterFactory 
    {
        public abstract Letter Create(Random random, int i);
    }
}
