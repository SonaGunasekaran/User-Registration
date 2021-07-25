using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace UserRegistration
{
   public class UserRegistrationExp
   {
        public string CheckName(string name)
        {
            string pattern = "^[A-Z][a-z]{3}[a-z]*$";
            Regex regex = new Regex(pattern);
            try
            {
                if (name == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Name should not be null");
                }
                if (name == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Name should not be empty");
                }
                if (regex.IsMatch(name))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (NullReferenceException e)
            {
                return (e.Message);
            }
        }
        public string CheckMail(string mail)
        {
            string pattern = @"^[a-z]{3}([\# \+ _\.]*[a-zA-Z0-9])*@[a-zA-z]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (regex.IsMatch(mail))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return "Email should not be null";
            }
        }
        public string PhoneNumberCheck(string number)
        {
            string pattern = @"^[1-9]{2}\s[1-9][0-9]{9}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (number == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Number should not be null");
                }
                if (number == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Number should not be empty");
                }
                if (regex.IsMatch(number))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        public string PasswordCheck(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[@#$%^&-+=()])[a-zA-Z0-9]{8,20}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (password == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Password should not be null");
                }
                if (password == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Password should not be empty");
                }
                if (regex.IsMatch(password))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        public static string TestUserRegistration(UserAnnotation userRegistration)
        {
            ValidationContext validationContext = new ValidationContext(userRegistration, null, null);
           List<ValidationResult> validationResults = new List<ValidationResult>();
          bool valid = Validator.TryValidateObject(userRegistration, validationContext, validationResults, true);
            try
            {
                if (!valid)
                {
                    foreach (ValidationResult validationResult in
                validationResults)
                        foreach (ValidationResult i in validationResults)
                        {
                            return i.ErrorMessage;
                        }
                    return "No feild available";
                }
                else
                {
                    return "Satisfied all the validation";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}
