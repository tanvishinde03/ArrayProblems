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
            Console.WriteLine(" 1:LengthofArray \n 2:MaxAndMin \n 3:NegativeNum \n 4: Sum of Numbers");
            Console.WriteLine("choose the option");
            int opiton = Convert.ToInt32(Console.ReadLine());

            switch (opiton)
            {
                case 1:
                    ArrayProblem arrayLength = new ArrayProblem();
                    arrayLength.CheckLenghtOfArray();
                    break;

                case 2:
                    ArrayProblem minMaxNUmber = new ArrayProblem();
                    minMaxNUmber.CheckMaxandMax();
                    break;

                case 3:
                    ArrayProblem nagative = new ArrayProblem();
                    nagative.CheckNegativeNum();
                    break;
                case 4:
                    ArrayProblem  sum = new ArrayProblem ();
                    sum.CheckSumofArr();
                    break;
            }
        }
    }
}
