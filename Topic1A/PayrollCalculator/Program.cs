namespace PayrollCalculator;

class Program
{
    const double TAX_RATE = 0.2d;
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter Employee name: ");
            string? name = Console.ReadLine();
            
            Console.Write("Hours worked: ");
            if (!double.TryParse(Console.ReadLine(), out double hours))
                throw new Exception("Invalid input for hours");
  
            Console.Write("Hourly rate: ");
            if (!double.TryParse(Console.ReadLine(), out double rate))
                throw new Exception("Invalid input for hours");

            double net_pay = CalculatePay(hours, rate);

            Console.WriteLine(name + " earned $" + $"{net_pay:F2}" + " after tax.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error has occured: {e.Message}");
        }
        
    }

    static double CalculatePay(double hours, double rate)
    {
        if (hours < 0 || rate < 0)
            throw new ArgumentException("Hours and rate must be positive");
        
        double gross, tax, net;

        gross = hours * rate;
        tax = gross * TAX_RATE;
        net = gross - tax;

        return net;
    }
}
