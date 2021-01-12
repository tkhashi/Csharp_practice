using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    public class AllLetterFactory : ILetterFactory
    {
        public Letter Create(Random random, int i)
        {
            Letter letter = null;
            int n = i % 4;
            if (n == 0) letter =  new NumLetter(random);
            if (n == 1) letter =  new LowerLetter(random);
            if (n == 2) letter =  new UpperLetter(random);
            if (n == 3) letter =  new MarkLetter(random);
            return letter;
        }
    }
}
