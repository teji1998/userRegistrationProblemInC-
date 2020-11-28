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
            Console.WriteLine("Enter your first name.");
            string firstName = Console.ReadLine();
            if (!userValidation.nameValidation(firstName))
            {
                Console.WriteLine("First name entered is invalid. \nPlease enter a valid first name : ");
                firstName = Console.ReadLine();
            }
            else
                Console.WriteLine("First name entered is valid");

            //Last name validation
            Console.WriteLine("Enter your last name.");
            string lastName = Console.ReadLine();
            if (!userValidation.nameValidation(lastName))
            {
                Console.WriteLine("Last name entered is invalid. \nPlease enter a valid last name : ");
                lastName = Console.ReadLine();
            }
            else
                Console.WriteLine("Last name entered is valid");

            //Email id validation
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();

           if (!userValidation.emailIdValidation(email))
            {
                Console.WriteLine("Email entered is invalid. \nPlease enter a valid email : ");
                email = Console.ReadLine();
            }
            else
                Console.WriteLine("Email entered is valid"); 

            //Mobile number validation
            Console.WriteLine("Enter your mobile number");
            string number = Console.ReadLine();
            if (!userValidation.mobileNumberValidation(number))
            {
                Console.WriteLine("Mobile number entered is invalid. \nPlease enter a valid mobile number : ");
                number = Console.ReadLine();
            }
            else
                Console.WriteLine("Mobile number entered is valid");

            //Password Validation
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (!userValidation.passwordValidation(password))
            {
                Console.WriteLine("Password entered is invalid. \nPlease enter a valid password : ");
                password = Console.ReadLine();

            }
            else
                Console.WriteLine("Password entered is valid");
            
        }
    
    }
}
