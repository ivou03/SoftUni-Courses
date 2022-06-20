using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int usernameLength = username.Length -1;
            string password = "";

            for (int value = usernameLength; value >= 0 ; value--)
            {
                password += username[value];
            }
            int countOfWrongPasswords = 0;
            string inputPass = Console.ReadLine();
            while (inputPass != password)
            {
                countOfWrongPasswords++;
                if (countOfWrongPasswords > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPass = Console.ReadLine();

            }
            if (inputPass == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
