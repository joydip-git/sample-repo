using System;
using CalculaulationLibrary;

namespace CalculaulationClient
{
    public class Program
    {
        public static void Main()
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Divide(10,2));
        }
    }
}
