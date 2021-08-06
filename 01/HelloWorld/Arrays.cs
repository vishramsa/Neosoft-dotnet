using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Arrays
    {
        internal static void SingleDimensionArray()
        {
            /*int[] marks;//declaration of array
            marks = new int[5]; // initialize/instantiate an array
            marks[0] = 80;
            marks[1] = 85;*/

            //int[] marks = new int[] { 80, 85, 67, 78, 98,96 };
            int[] marks = { 80, 85, 67, 78, 98,96 };
            Console.WriteLine($"Number of elements in an array {marks.Length}");
            Console.WriteLine($"Rank of an array {marks.Rank}");
            //for (int i = 0; i < marks.Length; i++)
            foreach(int mark in marks)
            {                
                Console.WriteLine(mark);
            }
        }
        internal static void MultiDimensionalArray()
        {
            /*int rows = 2, col = 3;
            int[,] matrix = new int[rows, col];
            matrix[0, 0] = 1;*/
           
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine($"Length of array {matrix.Length}");
            Console.WriteLine("Rank of the array {0}",matrix.Rank);
        }
        internal static void JaggedArrays()
        {
            int[][] ja = new int[3][];// initialize rows only
            //initialize columns
            ja[0] = new int[4] { 1, 2, 3, 4 }; // row 1
            ja[1] = new int[2] { 4, 5 }; // row 2
            ja[2] = new int[5] { 7, 8, 9, 2, 4 }; //row 3

            Console.WriteLine($"Length of array {ja.Length}");
            Console.WriteLine("Rank of the array {0}", ja.Rank);
            /*for (int i = 0; i < ja.Length; i++)
            {
                Console.Write("Row({0})",i);
                for (int j = 0; j < ja[i].Length; j++)
                {
                    Console.Write(ja[i][j] + " ");
                }
                Console.WriteLine();
            }*/
            foreach (int[] item in ja)
            {
                foreach (int i in item)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }
        }
    }
}
