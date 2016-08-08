using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal hours;
            decimal wages;
            decimal result;

            Console.WriteLine("Enter Hours: ");
            string hoursEntered = Console.ReadLine();
            Console.WriteLine("Enter Hourly Wages: ");
            string hourWages = Console.ReadLine();
            
            hours = Decimal.Parse(hoursEntered);
            wages = Decimal.Parse(hourWages);
            result = hours * wages;
            Console.WriteLine("Your pay is: " + result);
            Console.ReadLine();
            
            




        }
    }
}
