using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jagged array practice
            // Fibo within Fibo

            // Instructions
            // using a jagged array with the following properties
            // the first inner array (index 0) will have a length of 1
            // the second inner array (index 1) will have a length of 1
            // the third inner array onwards (index 2 onwards) will have
            // a length that is the sum of the previous 2 lengths.

            // The content of the arrays will also be the fibo

            // if we change this, the logic should scale
            int fiboArrayLength = 10;
            // this is the array that will hold the fibo within the fibo
            int[][] fibofibo = new int[fiboArrayLength][];
            // as per the instructions, the first two inner arrays will have a length of 1
            fibofibo[0] = new int[1];
            fibofibo[1] = new int[1];

            // this is the for loop block that will initialize the rest of the arrays
            // by taking the sum of the lengths of the previous 2 arrays
            for (int x = 2; x < fibofibo.Length; x++)
                fibofibo[x] = new int[fibofibo[x - 1].Length + fibofibo[x - 2].Length];

            // this is the logic that will fill the array with content
            for(int x = 0; x < fibofibo.Length; x++)
            {
                // since all the arrays will have at least the length of 1
                fibofibo[x][0] = 0;
                // this is the condition that will determine if the content of the array is more than 1
                if (fibofibo[x].Length > 1)
                {
                    // at minimum, any inner array will have a length of 2
                    fibofibo[x][1] = 1;
                    // this is the logic that will fill in the other values only when the inner array has a length
                    // greater than 2
                    for (int y = 2; y < fibofibo[x].Length; y++)
                        fibofibo[x][y] = fibofibo[x][y - 1] + fibofibo[x][y - 2];
                }
            }

            // this is just the logic that displays the finished array
            for(int x = 0; x < fibofibo.Length; x++)
            {
                for(int y = 0; y < fibofibo[x].Length;y++)
                {
                    Console.Write($"{fibofibo[x][y]}   ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
