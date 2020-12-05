using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace userRegistrationProblem
{
    public class RegexPattern
    {
        public static string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAIL_ID_PATTERN = "^[0-9a-z]+[+_.-]?[0-9a-z]+[@][0-9a-z]+[.][a-z]{2,}[.]?[a-z]+$";
        public static string MOBILE_NUMBER_PATTERN = "^[0-9]{2}[ ][6-9]{1}[0-9]{9}$";
        public static string PASSWORD_PATTERN = "^(?=.*[A-Z].*)(?=.*[0-9].*)(?=.*[@#$%^&*+_].*)[0-9a-zA-Z@#$%^&*+_]{8,}";

        public bool ValidFirstName(string name)
        {
            return Regex.IsMatch(name, NAME_PATTERN);
        }

        public bool ValidlastName(string name)
        {
            return Regex.IsMatch(name, NAME_PATTERN);
        }

        public bool ValidEmailId(string emailId)
        {
            return Regex.IsMatch(emailId, EMAIL_ID_PATTERN);
        }

        public bool ValidMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MOBILE_NUMBER_PATTERN);
        }

        public bool ValidPassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD_PATTERN);
        }

        public Func<string, bool> isValidFirstName = firstName => Regex.IsMatch(firstName, NAME_PATTERN);
    }
}
