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
            /* 
             * Instructions
             * ==========================================
             * 1 - A jagged array.
             * 2 - The outer array will have a length of 10.
             * 3 - The first and second inner array length will be 1.
             * 4 - The succeeding array lengths will have a length
             *     based on the fibonacci sequence of all the inner array lengths.
             * 5 - The array would contain the fibonacci sequence,
             *     the length of the sequence will be based on the length of the inner length.
             */

            /*
             * This line is almost uncecessary but will prove that if
             * we change the length of the outer array, the rest of the
             * logic would change alongside the length of the outer array
             * 
             * This is for instruction 2.
             */
            int fiboArrayLength = 10;
            /*
             * This is jagged array that would be holding the fibo in fibo
             * structure in the requirement.
             * 
             * This is for instruction 1.
             */
            int[][] fibofibo = new int[fiboArrayLength][];
            
            /*
             * Assigning/initializing/declaring a new length 
             * to the inner arrays of index 0 and 1
             * 
             * This is for instruction 3.
             */
            fibofibo[0] = new int[1];
            fibofibo[1] = new int[1];

            /*
             * Loop # 1:
             * =======================================
             * This for loop is dedicated to assigning/initializing/declaring
             * the inner arrays after index 1 until length n - 1.
             * 
             * The logic for this is explained in instruction 4.
             */
            for (int x = 2; x < fibofibo.Length; x++)
                fibofibo[x] = new int[fibofibo[x - 1].Length + fibofibo[x - 2].Length];

            /*
             * Loop # 2:
             * =======================================
             * This for loop is dedicated to assigning
             * values to each 'cell' or index in each inner array.
             * 
             * The logic for this is explained in instruction 5.
             * 
             * The outer for loop is dedicated to iterating through the outer arrays
             * touching each index for each of the outer array.
             */
            for (int x = 0; x < fibofibo.Length; x++)
            {
                /*
                 * Value Assignment # 1:
                 * =======================================
                 * since all the arrays will have at least the length of 1
                 * we can just assign the value '0' to index 0 of all inner arrays
                 */
                fibofibo[x][0] = 0;
                
                // this is the condition that will determine if the content of the array is more than 1
                if (fibofibo[x].Length > 1)
                {
                    /*
                     * Value Assignment # 1:
                     * =======================================
                     * At minimum, if the condition above is satisfied,
                     * the inner array will have a lenght of 2.
                     * 
                     * Similar to the logic of the Value Assignment # 2.
                     */
                    fibofibo[x][1] = 1;

                    /*
                     * Loop # 2.1:
                     * =======================================
                     * This is the typical logic of formulating the 
                     * fibunacci sequence.
                     * 
                     * You may actually refer to Loop # 1 for similarities
                     * in its overall logic formulation
                     */
                    for (int y = 2; y < fibofibo[x].Length; y++)
                        fibofibo[x][y] = fibofibo[x][y - 1] + fibofibo[x][y - 2];
                }
            }

            /*
             * Loop # 3:
             * =======================================
             * this is just the logic that displays the finished array
             * do notice that the for loops are actually the same as above
             */
            for (int x = 0; x < fibofibo.Length; x++)
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
