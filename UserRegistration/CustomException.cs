using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
           NULL_EXCEPTION, EMPTY_EXCEPTION, INVALID_EXCEPTION, NULL_FIELD_EXCEPTION
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
                this.type = type;
        }
    }
    
}
