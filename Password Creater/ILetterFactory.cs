using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Creater
{
    public interface ILetterFactory
    {
        Letter Create(Random random, int i);
    }
}
