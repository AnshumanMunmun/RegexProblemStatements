﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblemStatements
{
    public class UserValidation
    {
        public void FirstNameValidation()
        {
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            string firstname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(Firstname))
            {
                Console.Write("Name " + Firstname +  " is Valid \n");
            }
            else
            {
                Console.Write("Please Enter First Letter Capital \n");
            }
        }
        public void LastNameValidation()
        {
            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            string lastname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(lastname);
            if (regex.IsMatch(Lastname))
            {
                Console.Write("Name " + Lastname + " is Valid \n");
            }
            else
            {
                Console.Write("Please Enter First Letter Capital \n");
            }
        }
    }
}
