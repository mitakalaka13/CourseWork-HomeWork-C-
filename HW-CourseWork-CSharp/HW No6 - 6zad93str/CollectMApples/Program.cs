using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectMApples
{//6/93


    class Program
    {

        static void CollectMApples(  string  curPath,ref string finalPath, int currScore, ref int finalScore, int row, int col, int[,] a, int posX, int posY)
        {
            if (posX == row - 1 && posY == col - 1)
            {

                if (currScore >= finalScore)
                {
                    finalScore = currScore;
                    curPath = curPath.Substring(0, currPath.Length - 1);
                    finalPath = curPath;

                }

                currScore = 0;
                curPath = "";
                return;
            }
            if (posX == row - 1)
            {
                currScore += a[posX, posY];
                CollectMApples(  curPath += " R -",ref finalPath ,currScore, ref finalScore, row, col, a, posX, posY + 1);
                return;
            }
            if (posY == col - 1)
            {
                currScore += a[posX, posY];
                CollectMApples( curPath + " D -", ref finalPath, currScore, ref finalScore, row, col, a, posX + 1, posY);
                return;
            }

            currScore += a[posX, posY];
            
            CollectMApples( curPath + " R -", ref finalPath, currScore, ref finalScore, row, col, a, posX, posY + 1);
            CollectMApples( curPath + " D -", ref finalPath, currScore, ref finalScore, row, col, a, posX + 1, posY);
            
        }
        static void Main(string[] args)
        {
            int startPosX = 0;// initially top left
            int startPosY = 0;//initially top left
            string path = "";//initially
            string pathFinal = "";// ini-
            int score = 0;//ini-
            int finalScore = 0;//ini-
            int[,] matrix = new int[3, 4] { {0,1,4,1}, //could be changed.
                                            {1,2,1,2},
                                            {1,3,1,0}
                                                      };
            CollectMApples( path,ref pathFinal, score, ref finalScore, matrix.GetLength(0), matrix.GetLength(1), matrix, startPosX, startPosY);

            Console.WriteLine("Max apples you can collect "+finalScore+" apples!");
            Console.WriteLine("You can do this by moving "+pathFinal+" starting from [0,0]");

        
        }
    }
}
