using System;
using System.Collections.Generic;
using System.Text;

namespace userRegistrationProblem
{
    public class UserException : Exception
    {
        public enum ExceptionType
        {
            ENTERED_LESS_THAN_MINIMUM_LENGTH, HAVING_NUMERIC_VALUE, HAVING_SPECIAL_CHARACTER, WITHOUT_CAPITAL_LETTER, 
            WITHOUT_SPECIAL_CHARACTER, WITHOUT_SMALL_LETTER, WITHOUT_NUMBER, HAVING_SPACE, WITHOUT_SPACE_BETWEEN_NUMBERS,
            WITHOUT_COUNTRY_CODE,NOT_HAVING_ALPHABET, NOT_A_VALID_NUMBER,NOT_EMPTY,INVALID_LENGTH
        }

        ExceptionType exceptionType;

        public UserException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
            
        }
    }
}
