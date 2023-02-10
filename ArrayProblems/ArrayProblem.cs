using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ArrayProblem
    {
        public void CheckLenghtOfArray()
        {
            int[] array = { 2, 4, 5, 6, 7, 8, 9, 1, 3 };
            int arrayLength = array.Length;

            Console.WriteLine(" The Length of the array:" + arrayLength);
            Console.ReadLine();
        }

        public void CheckMaxandMax()
        {
            Console.WriteLine("Maximum and Minimum Numbers:");
            int[] array = { 20, 43, 55, 61, 79, 85, 99, 12, 34 };
            int max = array[0];
            int min = array[0];
            foreach (int i in array)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine("Maximum number in array is:" + max);
            Console.WriteLine("Minimum number in array is:" + min);
            Console.ReadLine();
        }

        public void CheckNegativeNum()
        {
            int[] array = { 220, -643, 55, -261, 179, 785, -99, 120, -340 };
            Console.WriteLine("Negative Numbers are:");
            foreach (int number in array)
            {
                if (number < 0)
                {
                    Console.WriteLine("Negative Numbers are" + number);
                }
            }
            Console.ReadLine();

        }
        public void CheckSumofArr()
        {
            int[] array = new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 };
            int sum = 0;


            Console.WriteLine("Find sum of all elements of array:");

            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum of all Elements of Array is " + sum);
            Console.ReadLine();
        }
    }
}










    

