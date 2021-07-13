using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration user = new Registration();
            Console.Write("Enter your first name:");
            string firstName = Console.ReadLine();
            user.Check(firstName);
            Console.Write("Enter your last name:");
            string lastName = Console.ReadLine();
            user.Check(lastName);

        }
    }
}
