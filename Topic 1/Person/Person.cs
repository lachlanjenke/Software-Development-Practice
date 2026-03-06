using System;

namespace PersonClass
{
    public class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

        public Person(string firstNameValue, string lastNameValue, int ageValue)
        {
            FirstName = firstNameValue;
            LastName = lastNameValue;
            Age = ageValue;
        }

        public string FullName()
        {
            return LastName + ", " + FirstName;
        }

        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}