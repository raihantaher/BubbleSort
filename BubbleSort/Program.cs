using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] theNumbers = { 4, 7, 3, 8, 6, 1, 2, 9, 5, 0 };

            // bubble sort
            for(int a = theNumbers.Length; a > 0; a--)
            {
                for(int b = 0; b < a-1; b++)
                {
                    if(theNumbers[b] > theNumbers[b+1])
                    {
                        int first = theNumbers[b];
                        theNumbers[b] = theNumbers[b+1];
                        theNumbers[b+1] = first;
                    }
                }
                //for (int y = 0; y < theNumbers.Length; y++)
                //{
                //    Console.Write(theNumbers[y]);
                //}
                //Console.WriteLine();
            }

            Console.WriteLine("Sorted numbers ");
            for(int x = 0; x < theNumbers.Length; x++)
            {
                if (x != 0)
                {
                    Console.Write(',');
                }
                Console.Write(theNumbers[x]);
            }
            Console.ReadKey();
        }
    }
}
