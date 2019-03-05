using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.
            // TODO: Call a method called FullName that returns their full name.
            // TODO: Output their full name.

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine().Trim();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine().Trim();

            Console.WriteLine(FullName(firstName, lastName));
            Console.ReadLine();
        }

        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
        private static string FullName(string firstName, string lastName)
        {
            string Name = "";
            Name = firstName + " " + lastName;
            return Name;
        }
    }
    
}
