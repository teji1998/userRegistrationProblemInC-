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
            if (!userValidation.passwordValidation(firstName))
            {
                Console.WriteLine("First name is invalid.Please enter first name according to specification.");
                firstName = Console.ReadLine();
            }
            else
                Console.WriteLine("First name entered is valid");

            //Last name validation
            Console.WriteLine("Enter your Lastname");
            string lastName = Console.ReadLine();
            if (!userValidation.passwordValidation(lastName))
            {
                Console.WriteLine("Last name is invalid.Please enter last name according to specification.");
                lastName = Console.ReadLine();
            }
            else
                Console.WriteLine("Last name entered is valid");

            //Email id validation
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            if (!userValidation.passwordValidation(email))
            {
                Console.WriteLine("Email is invalid.Please enter email according to specification.");
                email = Console.ReadLine();
            }
            else
                Console.WriteLine("Email entered is valid");

            //Mobile number validation
            Console.WriteLine("Enter your Mobilenumber");
            string number = Console.ReadLine();
            if (!userValidation.passwordValidation(number))
            {
                Console.WriteLine("Mobile number is invalid.Please enter mobile number according to specification.");
                number = Console.ReadLine();
            }
            else
                Console.WriteLine("Mobile number entered is valid");

            //Password Validation
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (!userValidation.passwordValidation(password))
            {
                Console.WriteLine("Password is invalid.Please enter password according to specification.");
                password = Console.ReadLine();

            }
            else
                Console.WriteLine("Password entered is valid");
            
        }
    
    }
}
