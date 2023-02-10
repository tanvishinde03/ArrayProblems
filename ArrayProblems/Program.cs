using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ArrayLength");
            Console.WriteLine("choose the option");
            int opiton = Convert.ToInt32(Console.ReadLine());

            switch (opiton)
            {
                case 1:
                    ArrayProblem arrayLength = new ArrayProblem();
                    arrayLength.CheckLenghtOfArray();
                    break;


            }
        }
    }
}
