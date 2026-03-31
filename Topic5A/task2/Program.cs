namespace task2;

class Program
{
    static void Main(string[] args)
    {
        // Create the list
        var names = new List<string> {"William", "Charlotte","Elijah","Hazel"};

        // Add a single name
        names.Add("Eddy");

        // Remove a name 
        names.Remove("Elijah");

        // Insert a name
        names.Insert(1,"Violet");

        // Add a range
        names.AddRange("Charlene","Charles","Harper","Makon","Charli");

        // Print list
        foreach (string name in names)
            Console.WriteLine(name);

        // Find index
        int nameIndex = names.IndexOf("Violet");
        Console.WriteLine("The name Violet is at the index" + nameIndex);

        // Search for Partial names
        foreach (string name in names)
        {
            if (name.Contains("Char"))
                Console.WriteLine(name);
        }

        // Sum the length of all names
        int namesTotal = 0; 
        foreach (string name in names)
            namesTotal += name.Length;

        Console.WriteLine("The length of all names combined is " + namesTotal);

        // Convert array to list
        string[] namesArray = {"Noah", "Charlie","Oliver","Amelia","Theo","Mia","Henry","Evelyn","Lachy","Ava"};
        var task1Names = namesArray.ToList();

        names.AddRange(task1Names);
        foreach (string name in names)
            Console.WriteLine(name);

    }
}
