using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;


namespace PMS
{
    class Validation
    {

        //Validate Email Address
        public bool ValidateEmail(string email)
        {
            email = email.ToLower();

            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            // ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            //boolean variable to return to calling method
            bool valid = false;
            //make sure an email address was provided
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                //use IsMatch to validate the address
                valid = check.IsMatch(email);
            }

            //return the value to the calling method
            return valid;
        }

        //Validate Required Field
        public bool ValidateTextField(string input)
        {
            bool valid = false;

            if ((input.Length == 0) || (input == null) || (input.Equals("")))
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;
        }

        //Validate NIC number
        public bool ValidateNIC(string nic)
        {
            string pattern = @"\d{9}[V|v|x|X]";
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

            //boolean variable to return to calling method
            bool valid = false;

            //make sure an email address was provided
            if (string.IsNullOrEmpty(nic))
            {
                valid = false;
            }
            else
            {
                //use IsMatch to validate the address
                valid = check.IsMatch(nic);
            }

            //return the value to the calling method
            return valid;
        }

    }
}
