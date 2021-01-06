using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password_Creater;

namespace WPF_PasswordCreator
{
    public class MainWindowVM
    {
        private ILetterFactory factory;
        private bool isNonMark;
        public bool IsNonMark
        {
            get{ return isNonMark; }
            set {
                isNonMark = value;
                if (isNonMark) {
                    factory = new NonMarkLetterFactory();
                } else {
                    factory = new AllLetterFactory();
                }
            }
        }
        private int numOfLetters;
        public int NumOfLetters
        {
            get { return numOfLetters; }
            set { numOfLetters = value; }
        }
        private string createdPassword;
        public string CreatedPassword
        {
            get { return createdPassword;}
            set { createdPassword = value; }
        }
        public MainWindowVM()
        {
            NumOfLetters = 20;
            IsNonMark = false;
            CreatedPassword = "This is WPF Application";
        }
    }
}
