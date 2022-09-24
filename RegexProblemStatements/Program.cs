namespace RegexProblemStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("User Registration Form ");
            while (true)
            {
                Console.WriteLine("Please choose the option :\n1. First Name \n2. Last Name \n3. Email \n4. Mobile Number " +
                    "\n5. Simple Password of 8 Characters \n6. Password With At least 1 Upper Case " +
                    "\n7. Password With At least 1 Number \n8. Password With At least 1 special character");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        userValidation.FirstNameValidation();
                        break;
                    case 2:
                        userValidation.LastNameValidation();
                        break;
                    case 3:
                        userValidation.Email();
                        break;
                    case 4:
                        userValidation.MobileNumber();
                        break;
                    case 5:
                        userValidation.Password();
                        break;
                    case 6:
                        userValidation.Password2();
                        break;
                    case 7:
                        userValidation.Password3();
                        break;
                    case 8:
                        userValidation.Password4();
                        break;
                    default:
                        Console.WriteLine("Please enter the correct value.");
                        break;
                }
            }
        }
    }
}