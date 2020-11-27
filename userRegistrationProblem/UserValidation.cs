using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace userRegistrationProblem
{
    class UserValidation
    {
        public const string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";

        public bool nameValidation(string name)
        {
            if (Regex.IsMatch(name, NAME_PATTERN))
                return true;
            return false;
        }
    }
}
