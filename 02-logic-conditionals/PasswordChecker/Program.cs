using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()?/<>;:,[]{}|-=";

            string password = Console.ReadLine();
            int score = 0;
            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            string message = "";

            switch (score)
            {
                case 5:
                    message = "Extremely strong";
                    break;
                case 4:
                    message = "Extremely strong";
                    break;
                case 3:
                    message = "Strong";
                    break;
                case 2:
                    message = "Medium";
                    break;
                case 1:
                    message = "Weak";
                    break;
                default:
                    message = "Try Again";
                    break;
            }
            Console.WriteLine(message);
        }
    }
}
