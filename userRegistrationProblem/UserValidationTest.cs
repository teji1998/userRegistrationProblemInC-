using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace userRegistrationProblem
{
    public class UserValidationTest
    {
        public void Display (string firstName, string lastName, string email, string number, string password)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("User class validation");
            Console.WriteLine("---------------------------------");
            UserDetails userDetails = new UserDetails();

            userDetails.Firstame = firstName;
            userDetails.LastName = lastName;
            userDetails.Number = number;
            userDetails.Email = email;
            userDetails.Password = password;

            ValidationContext context = new ValidationContext(userDetails, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(userDetails, context, results, true);

            if (!valid)
            {
                
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("MemberName:{0}", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("ErrorMsg::{0}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("First Name : " + userDetails.Firstame + "\n" + "Last Name : "  + userDetails.LastName + "\n" + "Mobile Number : " + userDetails.Number + "\n" + "Email : " + userDetails.Email + "\n" + " Password : " + userDetails.Password);
                
            }



        }
    }
}
