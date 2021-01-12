using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    public class Mark2LetterFactory : ILetterFactory
    {
        public Letter Create(Random random, int i)
        {
            if(i <= 1)
            {
                return new MarkLetter(random);
            } else {
                var factory = new NonMarkLetterFactory();
                return factory.Create(random, i);
            }
        }
    }
}
