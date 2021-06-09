using System;
using System.Linq;

namespace dom4
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckPassword(password);
        }
        static void CheckPassword(string password)
        {
            if (password.Length > 6 && password.Length < 10)
            {

            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if ((password.Count(c => Char.IsDigit(c)) > 1) && password.Count(c => Char.IsLetter(c)) > 1)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if ((!password.Any(Char.IsLetter)
               || !password.Any(Char.IsDigit)))
            {

            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
        }
    }
}
