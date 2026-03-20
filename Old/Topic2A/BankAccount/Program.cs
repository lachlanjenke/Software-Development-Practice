namespace BankAccount;

class Program
{
    static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount("Lachlan", 1000.42m);
        myAccount.Deposit(50);
        Console.WriteLine("The balance is now " + myAccount.Balance);
        myAccount.Deposit(100.539d);
        Console.WriteLine("The balance is now " + myAccount.Balance);
        myAccount.Deposit(3.21m);
        Console.WriteLine("The balance is now " + myAccount.Balance);
        myAccount.Withdraw(50.3m);
        Console.WriteLine("The balance is now " + myAccount.Balance);
        // myAccount.Withdraw(1000.42m);
    }
}

class BankAccount
{
    public string Owner { get; init; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountOwner, decimal initialVal)
    {
        Owner = accountOwner;
        Balance = initialVal;
    }

    public void Deposit(decimal ammount) { Balance += ammount; }

    public void Deposit(int ammount) { Balance += (decimal)ammount; }

    public void Deposit(double ammount) { Balance += (decimal)ammount; }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new Exception("Balance is too low for that amount.");
        else
            Balance -= amount;
    }
}
