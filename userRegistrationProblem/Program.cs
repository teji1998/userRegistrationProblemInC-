using System;

namespace userRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration problem ! ");

            UserValidationTest user = new UserValidationTest();
            user.Display("Tejaswini", "Kulkarni",  "tejasvinirpk@gmail.com", "91 9920275347", "Teji@1998");
            user.Display("Tejaswini", "Ku", "teji@% gmail.com", "9920275347", "Teji@");

            GarbageCollection garbage = new GarbageCollection();
            garbage.garbageCollection();
        }   
    
    }
}
