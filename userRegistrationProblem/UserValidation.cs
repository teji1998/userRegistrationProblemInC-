using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace userRegistrationProblem
{
    public class UserValidation
    {
        //Validation Patterns
        public const string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public const string EMAIL_ID_PATTERN = "^[0-9a-z]+[+_.-]?[0-9a-z]+[@][0-9a-z]+[.][a-z]{2,}[.]?[a-z]+$";
        public const string MOBILE_NUMBER_PATTERN = "^[0-9]{2}[ ][6-9]{1}[0-9]{9}$";
        public const string PASSWORD_PATTERN = "^(?=.*[A-Z].*)(?=.*[0-9].*)(?=.*[@#$%^&*+_].*)[0-9a-zA-Z@#$%^&*+_]{8,}";

        /// <summary>
        /// Names the validation.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public bool nameValidation(string name)
        {
            bool output = Regex.IsMatch(name, NAME_PATTERN);
            try
            {
                if (output == false)
                {
                    if (name.Equals(string.Empty))
                        throw new UserException(UserException.ExceptionType.NOT_EMPTY,
                            "Name should not be empty");
                    if (name.Any(char.IsWhiteSpace))
                        throw new UserException(UserException.ExceptionType.HAVING_SPACE,
                            "Name should not have a space");
                    if (name.Length < 3)
                        throw new UserException(UserException.ExceptionType.ENTERED_LESS_THAN_MINIMUM_LENGTH,
                            "Name should contain atleast three letters ");
                    if (!char.IsUpper(name[0]))
                        throw new UserException(UserException.ExceptionType.WITHOUT_CAPITAL_LETTER,
                            "Name should have first letter capital");
                    if (name.Any(char.IsDigit))
                        throw new UserException(UserException.ExceptionType.HAVING_NUMERIC_VALUE,
                            "Name should not have numbers");                  
                    if (name.Any(char.IsLetterOrDigit))
                        throw new UserException(UserException.ExceptionType.HAVING_SPECIAL_CHARACTER,
                            "Name should not contain special characters");
                }
            }catch (UserException userException)
            {
                throw userException;
            }
            return output;
        }
       

        /// <summary>
        /// Emails the identifier validation.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool emailIdValidation(string email)
        {
            bool output = Regex.IsMatch(email, EMAIL_ID_PATTERN);
            try
            {
                if (output == false )
                {
                    if (email.Equals(string.Empty))
                        throw new UserException(UserException.ExceptionType.NOT_EMPTY, "Email should not be empty");
                }
            }catch (UserException userException)
            {
                Console.WriteLine(userException.Message);
            }
            return output;
        }


        /// <summary>
        /// Mobiles the number validation.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public bool mobileNumberValidation(string number)
        {
            bool output = Regex.IsMatch(number, MOBILE_NUMBER_PATTERN);
            double indexOfNumber = 0.0;
            char[] index = number.ToCharArray();
            if (number.Length > 0)
            {
                indexOfNumber = char.GetNumericValue(index[3]);
            }

            try
            {
                if (output == false)
                {
                    if (number.Equals(string.Empty))
                        throw new UserException(UserException.ExceptionType.NOT_EMPTY,
                            "Mobile number should not be empty");
                    if (number.Length == 10)
                        throw new UserException(UserException.ExceptionType.WITHOUT_COUNTRY_CODE,
                            "Country code is absent");
                    if (!number.Any(char.IsWhiteSpace))
                        throw new UserException(UserException.ExceptionType.WITHOUT_SPACE_BETWEEN_NUMBERS,
                            "There should be space between country code and mobile number");
                    if (number.Length > 13)
                        throw new UserException(UserException.ExceptionType.INVALID_LENGTH,
                            "The length of mobile number is invalid");
                    if (number.Any(char.IsLetter))
                        throw new UserException(UserException.ExceptionType.NOT_HAVING_ALPHABET,
                            "There should be no alphabets");
                    if (indexOfNumber < 6)
                        throw new UserException(UserException.ExceptionType.NOT_A_VALID_NUMBER, "Mobile Number starts with greater than 6");
                    if (number.Any(char.IsLetterOrDigit))
                        throw new UserException(UserException.ExceptionType.WITHOUT_SPECIAL_CHARACTER,
                            "There should be no special characters");                  

                }
            }catch (UserException userException)
            {
               throw userException;
            }
            return output;
        }

        /// <summary>
        /// Passwords the validation.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool passwordValidation(string password)
        {
            bool output = Regex.IsMatch(password, PASSWORD_PATTERN);
            try
            {
                if (output == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserException(UserException.ExceptionType.NOT_EMPTY,
                            "Password should not be empty");
                    if (password.Any(char.IsWhiteSpace))
                        throw new UserException(UserException.ExceptionType.HAVING_SPACE,
                            "Password should not have a space");
                    if (password.Length < 8)
                        throw new UserException(UserException.ExceptionType.ENTERED_LESS_THAN_MINIMUM_LENGTH,
                            "Password should be of atleast 8 characters");
                    if (!password.Any(char.IsDigit))
                        throw new UserException(UserException.ExceptionType.WITHOUT_NUMBER,
                            "Password should contain numbers");
                    if (!password.Any(char.IsLower))
                        throw new UserException(UserException.ExceptionType.WITHOUT_SMALL_LETTER,
                            "Password should have atleast one lower case letter");
                    if (!password.Any(char.IsUpper))
                        throw new UserException(UserException.ExceptionType.WITHOUT_CAPITAL_LETTER,
                            "Password should consist of capital letters");
                    if (!password.Any(char.IsLetterOrDigit))
                        throw new UserException(UserException.ExceptionType.WITHOUT_SPECIAL_CHARACTER,
                            "Password should contain special character");
                }
            }catch (UserException userException)
            {
                throw userException;
            }
            return output;
        }
    }
}
