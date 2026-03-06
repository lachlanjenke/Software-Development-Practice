using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            for (int i = 0; i < 10; i ++) 
            {
                Console.WriteLine("Enter a command: ");
                string? input = Console.ReadLine();

                string[] splitInput = input.Split(' ');

                switch(splitInput[0])
                {
                    case "add":
                        tasks.Add(splitInput[1]);
                        break;
                    case "show":
                        foreach (string task in tasks)
                        {
                            Console.WriteLine(task);
                        }
                        break;
                    case "remove": 
                        int index;
                        if (!int.TryParse(splitInput[1],out index))
                        {
                            do
                            {
                                Console.WriteLine("Enter an int: ");
                                splitInput[1] = Console.ReadLine();
                            } while (!int.TryParse(splitInput[1],out index));
                        }
                        while(index > tasks.Count - 1 || index < 0)
                        {
                            Console.Write("Index is not valid, enter again: ");
                            if (!int.TryParse(Console.ReadLine(), out index))
                            {
                                Console.Write("Must be an int");
                                index = -1;
                            }
                        }
                        tasks.RemoveAt(index);
                        break;
                    case "clear": 
                        tasks.Clear();
                        break;
                    default:
                        Console.WriteLine("Command not recognised, try again");
                        break; 
                }
            }
        }
    }
}