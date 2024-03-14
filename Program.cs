/* Program.cs
 * Console application that calculates the pay for a worker based on the hours worked and the rate of pay.
 * 
 * Revision History:
 *  Matheus Carvalho dos Santos 2024.01.23: Created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string name;
            double payRate;
            double hours;
            double preTax;
            double taxRate = .20;
            double taxAmount;
            double total;

            //get inputs
            Console.WriteLine("Enter you name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter hours worked: ");
            hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rate of pay:");
            payRate = Convert.ToDouble(Console.ReadLine());

            //calculate wages
            preTax = hours * taxRate;
            taxAmount = preTax * taxRate;
            total = preTax - taxAmount;

            //show calculated values to user
            Console.WriteLine($"\nPay for {name} ---------\n");
            Console.WriteLine($"Hours worked: {hours}");
            Console.WriteLine($"Pay Rate:     {payRate.ToString(".00")}");
            Console.WriteLine($"Pre-tax:      {preTax.ToString("C")}");
            Console.WriteLine($"Tax Amount:   {taxAmount.ToString("C")}");


            Console.ReadKey();
        }
    }
}
