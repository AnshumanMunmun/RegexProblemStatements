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
                Console.WriteLine("Please choose the option :\n1. First Name \n2. Last Name \n3. Email \n4. Mobile Number");
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
                    default:
                        Console.WriteLine("Please enter the correct value.");
                        break;
                }
            }
        }
    }
}