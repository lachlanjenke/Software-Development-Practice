using System;
using Microsoft.VisualBasic;

namespace PayrollCalculator
{
    class Program
    {
        const float TAX_RATE = 0.2f;
        static void Main(string[] args)
        {
            
        }

        static double CalculatePay(double hours, double rate)
        {
            if (hours < 0 || rate < 0)
            {
                throw new ArgumentException("Hours and rate must be positive");
            }
            double gross, tax, net;

            gross = hours * rate;
            tax = gross * TAX_RATE;
            net = gross - tax;

            return net;
        }
    }
}