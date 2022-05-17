using System;
using System.Collections.Generic;
using System.Linq;

namespace DPIntSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 3, 2, 4, 10 ,11, 34, 2, 45,  23, 1, 55, 355, 23, 12, 5, 6, 7, 8, 3, 2,2 ,5 ,4 ,1 ,54 ,34, 6, 346, 346,34, 646, 3534,};

            FindLargestSequence(array);
        }


        static void FindLargestSequence(int[] array)
        {
            int arrL = array.Length;

            int maxLength = 0;

            // Preparing arrays for the indexing info
            int[] sequenceLength = new int[arrL];
            int[] predecessor = new int[arrL];
            for (int i = 0; i < arrL; i++)
            {
                predecessor[i] = -1;
            }
            for (int i = 0; i < arrL; i++)
            {
                sequenceLength[i] = 1;
            }
            // Ends here

            for (int i = 1; i < arrL; i++)
            {

                for (int j = i - 1; j >= 0; j--)
                {
                    
                    if (array[i] > array[j])
                    {
                        if (sequenceLength[j] > sequenceLength[i] - 1)
                        {
                            sequenceLength[i] += sequenceLength[j];
                            predecessor[i] = j;
                        }
                        if (sequenceLength[i] > maxLength)
                        {
                            maxLength = i;
                        }
                        
                       
                    }
                }

            }

            Console.WriteLine("Largest sequence is.. ");
            List<int> answer = new List<int>();

            int pred = predecessor[maxLength];
            answer.Add(array[maxLength]);

            while (pred != -1)
            {
                answer.Add(array[pred]);
                pred = predecessor[pred];
            }

            answer.Reverse();
            Console.WriteLine(string.Join(", ", answer));
        }
    }
}
