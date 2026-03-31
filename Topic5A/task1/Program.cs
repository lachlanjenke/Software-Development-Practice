namespace task1;

class Program
{
    static void Main(string[] args)
    {
        string[] names = {"Noah", "Charlie","Oliver","Amelia","Theo","Mia","Henry","Evelyn","Lachy","Ava"};

        // Print Array
        foreach (string name in names)
            Console.WriteLine(name);

        // Find longest and shortest names
        string shortestName, longestName;
        shortestName = longestName = names[0];

        foreach (string name in names)
        {
            // Check if Longest
            if (name.Length > longestName.Length)
                longestName = name;
            // Check if Shortest
            else if (name.Length < shortestName.Length)
                shortestName = name;
        }
        Console.WriteLine("Longest is: " + longestName + ", Shorest is: " + shortestName);

        // Print before Sorting
        Console.WriteLine("Before sorting");
        foreach (string name in names)
            Console.Write(name + " ");
            
        Console.WriteLine(); // New line

        Array.Sort(names); // Sort

        // Print after Sorting
        Console.WriteLine("After sorting");
        foreach (string name in names)
            Console.Write(name + " ");

        Console.WriteLine(); // New line

        // Print before Reversal 
        Console.WriteLine("Before reversal");
        foreach (string name in names)
            Console.Write(name + " ");

        Console.WriteLine(); // New line

        Array.Reverse(names);

        // Print after Reversal 
        Console.WriteLine("Before reversal");
        foreach (string name in names)
            Console.Write(name + " ");
            
        Console.WriteLine(); // New line
    }
}
