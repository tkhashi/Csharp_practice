using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password_Creater;

namespace PasswordCreatorUI
{
    public class Controller
    {
        private Random random;
        private ILetterFactory factory;
        public Controller()
        {
            this.random = new Random();
            factory = new AllLetterFactory();
        }
        public int NumOfLetters { get; set; } = 12;
        private bool isNonMark;
        public bool IsNonMark
        {
            get { return isNonMark; }
            set
            {
                isNonMark = value;
                if (isNonMark)
                {
                    factory = new NonMarkLetterFactory();
                }
                else
                {
                    factory = new AllLetterFactory();
                }
            }
        }
        public string MakePasssword()
        {
            var generator = new PasswordGenerator(random);
            return generator.MakePassword(NumOfLetters, factory);
        }
    }
}
