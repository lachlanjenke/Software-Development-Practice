using System;
using PersonClass;

namespace Program
{
    class Program

    {
        static void Main(string[] args)
        {
            // Create instance of class
            Person me = new Person("Lachlan","Jenke",20);

            // Test full name function
            Console.WriteLine(me.FullName());

            // Test is adult function
            bool adult = me.IsAdult();
            if (adult)
                Console.WriteLine("They are an adult");
            else
                Console.WriteLine("They are not an adult");

        }
    }
}