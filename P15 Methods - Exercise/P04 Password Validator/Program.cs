using System;

namespace P04_Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minLeght = 6;
            const int maxLeght = 10;
            const int minCountOfDigit = 2;
            string password = Console.ReadLine();
            bool isCorrectLenght = ChecklenghtOfPassword(password, minLeght, maxLeght);
            bool isCorectCharachter = CheckOnlylettersAndDigits(password);
            bool isValidDigit = CheckMinCountOfDigit(password, minCountOfDigit);

            if (isCorrectLenght && isCorectCharachter && isValidDigit)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ChecklenghtOfPassword(string password, int minLenght, int maxLenght)
        {
            bool isCorrectLenght = true;
            if (password.Length < minLenght || password.Length > maxLenght)
            {
                isCorrectLenght = false;
                Console.WriteLine($"Password must be between {minLenght} and {maxLenght} characters");
            }
            return isCorrectLenght;
        }
        static bool CheckOnlylettersAndDigits(string password)
        {
            bool isCorectCharachter = true;
            foreach (char item in password)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    isCorectCharachter = false;
                }
            }
            if (!isCorectCharachter)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            return isCorectCharachter;
        }
        static bool CheckMinCountOfDigit(string password, int minCountOfDigit)
        {
            bool isValidDigit = true;
            int counter = 0;
            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    counter++;
                }
            }
            if (counter < minCountOfDigit)
            {
                isValidDigit = false;
                Console.WriteLine($"Password must have at least {minCountOfDigit} digits");
            }
            return isValidDigit;
        }
    }
}
