using System;

namespace PersonClass {
    class Person
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastName, int age)
        {
            // Validate first and last names
            if(String.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First Name cannot be null");

            if(String.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last Name cannoot be null");

            // Check if the age is within a possible range
            if (age < 0 || age > 130)
                throw new ArgumentException("Age must be between 0 and 130");

            // Assign variables
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Return full name
        public string FullName() { return LastName + ", " + FirstName; }

        public bool IsAdult()
        {
            if(Age >= 18)
                return true;
            else
                return false;   
        }
    }
}