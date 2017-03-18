using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletSum
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //int SumResult = 15;
            int SumResult = 8;

            //int[] Array = new int[] {14, 1, 2, 3, 8, 15, 3};
            int[] Array = new int[] {1, 1, 2, 5, 3};

            if (tripletSum(Array, SumResult))
            {
                Console.WriteLine("Woooohooo we got what we wanted awesome!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
            Console.ReadKey();
        }

        private static bool tripletSum(int[] array, int sumResult)
        {
            int left, right;

            Array.Sort(array);
            
            for(int i = 0; i < array.Length - 2; i++)
            {
                left = i + 1;
                right = array.Length - 1;

                do
                {
                    int numberToEvaluate = array[i] + array[left] + array[right];
                    if (numberToEvaluate == sumResult)
                    {
                        Console.WriteLine("The sum of the numbers {0},{1},{2} are equal to the given number {3}", array[i],array[left],array[right],sumResult);
                        return true;
                    }
                    else if (numberToEvaluate < sumResult )
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }

                } while (left < right);
            }
            Console.WriteLine("We couldn't find three numbers that summed up where equal to the given number so sorry!!");
            return false;
        }
    }
}
