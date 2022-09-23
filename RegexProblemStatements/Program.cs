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
                Console.WriteLine("Please choose the option :\n1. First Name \n2. Last Name");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        userValidation.FirstNameValidation();
                        break;
                    case 2:
                        userValidation.LastNameValidation();
                        break;
                    default:
                        Console.WriteLine("Please enter the correct value.");
                        break;
                }
            }
        }
    }
}