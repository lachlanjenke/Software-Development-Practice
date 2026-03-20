using System;
using System.Collections.Specialized;
using System.Text;
using PersonClass;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("Lachlan","Jenke",20);
            Console.WriteLine(me.FullName());

            bool adult = me.IsAdult();
            if (adult)
            {
                Console.WriteLine("They are an adult");
            }
            else
            {
                Console.WriteLine("They are not an adult");
            }
        }
    }   
}