namespace Payroll;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Payroll {
    const double TAX_RATE = 0.2d;
    private double hours;
    private double rate;   

    Payroll(double employeeHours, double employeeRate)
    {
        hours = employeeHours;
        rate = employeeRate;
    }

    public double CalculatePay()
    {
        if(hours < 0 || rate < 0)
        {
            throw new ArgumentException("Hours and Rate must be positive");
        }

        double gross, tax, net;

        gross = hours * rate;
        tax = gross * TAX_RATE;
        net = gross - tax;

        return net;
    }
}
