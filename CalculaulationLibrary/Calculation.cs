using System;

namespace CalculaulationLibrary
{
    public class Calculation
    {
        public int Divide(int first, int second)
        {
            if (second == 0)
                throw new DivideByZeroException("denominator can't be zero");

            if (first < 0 || second < 0)
                throw new ArgumentException("none of the values can be negative");

            return first / second;
        }
    }
}
