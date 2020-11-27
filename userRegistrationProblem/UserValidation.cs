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

        public bool nameValidation(string name)
        {
            if (Regex.IsMatch(name, NAME_PATTERN))
                return true;
            return false;
        }

        public bool Email_validation(string email)
        {
            if (Regex.IsMatch(email, EMAIL_ID_PATTERN))
                return true;
            return false;
        }
    }
}
