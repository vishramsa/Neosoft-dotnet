using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Array1
    {
        internal static void singleDimensionArray()
        {
            int[] marks;
            marks = new int[5];
            marks[0] = 86;
            marks[1] = 90;
            Console.WriteLine($"Number of elements in an array : {marks.Length}");
            Console.WriteLine($"Rank of the array : {marks.Rank}");
            Console.WriteLine("Looping through for loop");
            for(int i=0; i < marks.Length; i++) Console.WriteLine(marks[i]);
            Console.WriteLine("Looping through for-each loop");
            foreach(int mark in marks) Console.WriteLine(mark);
        }
        internal static void multiDimensional()
        {
            /*int rows = 2, cols = 3;
            int[,] matrix = new int[rows, cols];
            matrix[0, 0] = 1;*/

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine($"Lenght of an array{matrix.Length}");
        }

        internal static void jaggedArray()
        {
            int[][] ja = new int[3][]; //initialize rows only
            //initializing columns
            ja[0] = new int[4] { 1, 2, 3, 4 }; //row1
            ja[1] = new int[2] { 5, 6 };  //row2
            ja[2] = new int[5] { 7, 8, 9, 10, 11 }; //row3

            Console.WriteLine($"Length of the array : {ja.Length}");
            Console.WriteLine($"Rank of the array : {ja.Rank}");

            for (int i = 0; i < ja.Length; i++)
            {
                for (int j = 0; j < ja[i].Length; j++) 
                {
                    
                    Console.Write(ja[i][j] + "\t"); 
                
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Looping throught for each loop");
            foreach(int[] items in ja)
            {
                foreach(int item in items)
                {
                    Console.Write(item+"\t");
                }
                Console.WriteLine();
            }


        }
    }
}
