namespace Payroll;

class Program
{
    static void Main(string[] args)
    {
        Payroll payrollObj = new Payroll();
        bool error = false;

        try
        {
            payrollObj.Hours = -20.5d;
            payrollObj.Rate = 32.2d;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            error = true;
        }
        finally
        {
            if(!error)
            {
                Console.WriteLine("Hours is " + payrollObj.Hours + " and rate is " + payrollObj.Rate);
                
                double pay = payrollObj.CalculatePay();
                Console.WriteLine("The pay is " + pay);
            }
        }
    }
}

class Payroll {
    const double TAX_RATE = 0.2d;

    public Payroll()
    {
        Hours = 0d;
        Rate = 0d;
    }

    public double CalculatePay()
    {
        double gross, tax, net;

        gross = Hours * Rate;
        tax = gross * TAX_RATE;
        net = gross - tax;

        return net;
    }

    public double Hours
    {
        get;
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Hours must be positive");
            }

            field = value;
        }
    }

    public double Rate
    {
        get;
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Rate must be positive");
            }

            field = value;
        }
    }
}
