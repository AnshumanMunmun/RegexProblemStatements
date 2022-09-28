using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblemStatements
{
    internal class EmailValidation
    {
        public void EmailSample()
        {
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            string emailFormat = "^[A-Za-z0-9](.[-+A-Za-z0-9])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$";          //"^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex = new Regex(emailFormat);
            if (regex.IsMatch(email))
            {
                Console.Write("Given Email ID " + email + " is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Email ID in Proper Manner. For example:- abc.xyz@bl.co.in \n");
            }
        }
    }
}
