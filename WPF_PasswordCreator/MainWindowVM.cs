using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password_Creater;

namespace WPF_PasswordCreator
{
    public class MainWindowVM : ViewModel
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
                    factory = new Mark2LetterFactory();
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
            set { createdPassword = value; OnPropertyChanged(); }
        }
        public DelegateCommand MakePassword { get; private set; }
        private void MakePasswordExecute()
        {
            Random random = new Random();
            var generator = new PasswordGenerator(random);
            CreatedPassword = generator.MakePassword(NumOfLetters, factory);
        }
        public MainWindowVM()
        {
            NumOfLetters = 20;
            IsNonMark = false;
            MakePassword = new DelegateCommand(MakePasswordExecute, CanMakePasswordExecute);
        }
        private bool CanMakePasswordExecute()
        {
            return NumOfLetters > 10;
        }
    }
}
