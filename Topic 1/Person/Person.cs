using System;

namespace Person
{
    public class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

        Person(string firstNameValue, string lastNameValue, int ageValue)
        {
            FirstName = firstNameValue;
            LastName = lastNameValue;
            Age = ageValue;
        }
    }
}