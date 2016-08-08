using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int iNumber = 0;
            while (iNumber < 100)
            {
                iNumber++;
                if (iNumber % 3 == 0 && iNumber % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (iNumber % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (iNumber % 3 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else
                {
                    Console.WriteLine(iNumber);
                }
            }
                    Console.Read();
        }
    }
}

