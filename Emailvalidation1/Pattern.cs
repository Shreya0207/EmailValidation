using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailValidation1
{
    class Pattern
    {
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public bool ValidateEmail(string mail)
        {
            return Regex.IsMatch(mail, EMAIL_REGEX);
        }
    }
}
