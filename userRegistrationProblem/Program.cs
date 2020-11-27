using System;

namespace userRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration problem ! ");

            UserValidation userValidation = new UserValidation();

            //First name validation
            Console.WriteLine("Enter your Firstname");
            string firstName = Console.ReadLine();
            Console.WriteLine(userValidation.nameValidation(firstName));

            //Last name validation
            Console.WriteLine("Enter your Lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine(userValidation.nameValidation(lastName));

            //Email id validation
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Console.WriteLine(userValidation.Email_validation(email));
        }
    
    }
}
