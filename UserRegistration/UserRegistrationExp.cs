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
            //regex pattern is created to check validity
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
                // IsMatch method check the pattern and name
                if (regex.IsMatch(name))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (NullReferenceException ex)
            {
                return (ex.Message);
            }
        }
        public string CheckMail(string mail)
        {
            //regex pattern is created to check validity
            string pattern = @"^[a-z]{3}([\# \+ _\.]*[a-zA-Z0-9])*@[a-zA-z]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex regex = new Regex(pattern);
            try
            {
                // IsMatch method check the pattern and mail
                if (regex.IsMatch(mail))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                return "Email should not be null";
            }
        }
        public string PhoneNumberCheck(string number)
        {
            //regex pattern is created to check validity
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
                // IsMatch method check the pattern and PhoneNumber
                if (regex.IsMatch(number))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
        public string PasswordCheck(string password)
        {
            //regex pattern is created to check validity
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
                // IsMatch method check the pattern and password
                if (regex.IsMatch(password))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
        public static string ValidateUserRegistration(UserAnnotation userRegistration)
        {
            ValidationContext validationContext = new ValidationContext(userRegistration, null, null);
            //A list is created to hold the validation results
            List<ValidationResult> validationResults = new List<ValidationResult>();
            //Validator class returns true if the validation is successful, false otherwise
            bool valid = Validator.TryValidateObject(userRegistration, validationContext, validationResults, true);
            try
            {
                //if anyone of the results become invalid then it returns sad
                if (!valid)
                {
                    foreach (ValidationResult i in validationResults)
                    {
                        return "Sad";
                    }
                    return "Sad";
                }
                //if all the validations are true then it returns happy
                else
                {
                    return "Happy";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}

