using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mousem3
{
    class Program
    {//4zad/93

        static int counter = 1;
        static int mouX = 1; static int mouY = 1; //mouse - mou
        static int cheX = 3; static int cheY = 2; //cheese - che

        public static int[,] maze = {
            { 0, 0, 0, 0 },//1: wall / 0:free space
            { 0, 0, 1, 0 },
            { 0, 1, 1, 0 },
            { 0, 0, 0, 0 }
            
        };


        public static int[,] solution ={   //do not change used for solution
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 }

        };
        public static void FindAllPaths(int mouX, int mouY, int[,] sol)
        {
            

            if (!IsCellValid(mouX, mouY)) return;

            if (mouX == cheX && mouY == cheY)//found
            {
                sol[mouX, mouY] = 9;
                Console.WriteLine("Solution No." + (counter++));
                PrintSolution(sol);
               
                Console.WriteLine();
            }
            else if (IsCellValid(mouX, mouY))
            {
                maze[mouX, mouY] = 1;
                sol[mouX, mouY] = 1;

                FindAllPaths(mouX + 1, mouY, sol); //down
                FindAllPaths(mouX - 1, mouY, sol); //up
                FindAllPaths(mouX, mouY + 1, sol); //right
                FindAllPaths(mouX, mouY - 1, sol); //left

                maze[mouX, mouY] = 0;
            }
            sol[mouX, mouY] = 0;

            
        }

        public static bool IsCellValid(int x , int y)
        {
            if (x < 0 || x >= maze.GetLength(0))
            {
                return false;
            }

            if (y < 0 || y >= maze.GetLength(0))
            {
                return false;
            }
            if (maze[x, y] == 1)
            {
                return false;
            }


            return true;
        }

        public static void PrintSolution(int[,] a)
        {
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        } 
                
       
        static void Main(string[] args)
        {
            FindAllPaths(mouX, mouY, solution);
        }        
    }
}
