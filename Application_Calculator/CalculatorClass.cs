using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Calculator
{
    //declaring a generic delegate named Formula
    public delegate T Formula<T>(T arg, T arg1);
    internal class CalculatorClass
    {
        //declaring generic delegate's variable and set its data type to double
        public Formula<double> formula;

        //creating two methods that return the sum and the difference
        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        //creating two methods named GetProduct and GetQuotient
        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;

        }
        public double GetQoutient(double num1, double num2)
        {
            return num1 / num2;
        }

        //adding event accessor named CalculateEvent w/ two methods add and remove
        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the delegate");
                formula += value;
            }
            remove
            {
                Console.WriteLine("Remove the delegeate");
                formula -= value;
            }

        }
    }
}
