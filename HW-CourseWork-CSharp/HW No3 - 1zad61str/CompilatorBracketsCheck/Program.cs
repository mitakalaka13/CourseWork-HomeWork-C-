using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompBracketsCheck//zad1/stranica61
{
    class Program
    {
       
        static bool isParenthCorrect(string parenths)
        {

            int oCount = 0;//opening parenths

            if (parenths.Length <= 1)
                return false;

            for (int i = 0; i < parenths.Length; i++)
            {
                if (parenths[i].Equals('('))
                    oCount++;

                else if (parenths[i].Equals(')'))
                {
                    oCount--;
                    if (oCount < 0)
                        return false;
                }
            }

            return (oCount == 0);
        }
        static void Main(string[] args)
        {
            //testing 
            string try1 = "((())())()";// return true
            string try2 = ")()(";// return false
            string try3 = "())";//should return false
            Console.WriteLine(test1 + " returns " + isParenthCorrect(try1));
            Console.WriteLine(test2 + " returns " + isParenthCorrect(try2));
            Console.WriteLine(test3 + " returns " + isParenthCorrect(try3));

            
        }
    }
}
