using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {//zad12/str28
        public static bool CheckIfPolidrom(string duma)
        {

            char[] charWord = duma.ToCharArray();
            int reverseCount = duma.Length - 1;
            bool isTrue = true;
            for (int i = 0; i < charWord.Length; i++)
            {
                if (charWord[i] != charWord[reverseCount]) isTrue = false;
                reverseCount--;
            }
            return isTrue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if the word is polidrom");
            Console.WriteLine(CheckIfPolidrom(Console.ReadLine()));
        }
    }
}
