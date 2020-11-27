using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace userRegistrationProblem
{
    class UserValidation
    {
        public const string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public const string EMAIL_ID_PATTERN = "^[0-9a-z]+[+_.-]?[0-9a-z]+[@][0-9a-z]+[.][a-z]{2,}[.]?[a-z]+$";
        public const string MOBILE_NUMBER_PATTERN = "^[0-9]{2}[ ][0-9]{10}";
        public const string PASSWORD_PATTERN = "^(?=.*[A-Z].*)(?=.*[0-9].*)(?=.*[@#$%^&*+_].*)[0-9a-zA-Z@#$%^&*+_]{8,}";

        public bool nameValidation(string name)
        {
            if (Regex.IsMatch(name, NAME_PATTERN))
                return true;
            return false;
        }

        public bool emailIdValidation(string email)
        {
            if (Regex.IsMatch(email, EMAIL_ID_PATTERN))
                return true;
            return false;
        }

        public bool mobileNumberValidation(string number)
        {
            if (Regex.IsMatch(number, MOBILE_NUMBER_PATTERN))
                return true;
            return false;
        }

        public bool passwordValidation(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_PATTERN))
                return true;
            return false;
        }
    }
}
