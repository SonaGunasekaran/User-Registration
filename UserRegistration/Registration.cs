using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Registration
    {
        public void Check(string name)
        {
            //regex pattern is created to check validity
            string pattern = "[A-Z][a-z]{3}[a-z]*";
            Regex regex = new Regex(pattern);
            // IsMatch method check the pattern and name
            if (regex.IsMatch(name))
            {
                Console.WriteLine("Name {0} is Valid ", name);
            }
            else
            {
                Console.WriteLine("Name {0} is Invalid", name);
            }
        }
        public void CheckMail(string mail)
        {
            //regex pattern is created to check validity
            string pattern = @"^[a-z]{3}([\# \+ _\.]*[a-zA-Z0-9])*@[a-zA-z]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex regex = new Regex(pattern);
            // IsMatch method check the pattern and mail
            if (regex.IsMatch(mail))
            {
                Console.WriteLine("Email :{0} is Valid", mail);
            }
            else
            {
                Console.WriteLine("Email :{0} is Invalid", mail);
            }
        }
        public void PhoneNumberCheck(string num)
        {
            string pattern = @"^[1-9]{2}\s[1-9][0-9]{9}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(num))
            {
                Console.WriteLine("Mobile Number {0} is valid", num);
            }
            else
            {
                Console.WriteLine("Mobile Number {0} is invalid", num);
            }
        }
        public void PasswordCheck(string psw)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[@#$%^&-+=()])[a-zA-Z0-9]{8,20}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(psw))
            {
                Console.WriteLine("Password {0} is valid", psw);
            }
            else
            {
                Console.WriteLine("Password {0} is invalid", psw);
            }
        }

    }
}
