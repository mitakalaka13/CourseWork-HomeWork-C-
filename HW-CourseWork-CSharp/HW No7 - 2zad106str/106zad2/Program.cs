using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __zad2str106
{ //106/2 
    class Program
    {
        public static bool CheckForPairSumEqualToX(int[]s,int y)
        {
            int low = 0;
            int high = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
              
                if (s[low] + s[high] > y)
                {
                    high--;
                }
                else if (s[low] + s[high] < y)
                {
                    low++;
                }
                else if (low != high)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int X = 2;
            int[] S = new int[] { 1, 2, 3, 4, 5, 7, 20, 7 };
            Console.WriteLine(CheckForPairSumEqualToX(S,X));//shoudl return true
        }
    }
}
