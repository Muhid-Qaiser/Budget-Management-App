using System;
using System.Text.RegularExpressions;

namespace Expense_Tracker
{
    internal class BVT
    {
 
        string[] passwords = { "", "muhid", "muhiddd", "muhidddd", "MUHIDDDD", "Muhiddddd", "Muhid123", "Muhid123$", "Muhid123$$$$$", "Muhid123$$$$$$$$$$$"  ,  "Muhid123$$$$$$$$$$$$", "Muhid123$$$$$$$$$$$$$", "Muhid123$$$$$$$$$$$$$$$" };

        private void registeration_BV_testing(string register_password)
        {
            if (register_password.Length < 8)
            {
                Console.WriteLine("Invalid password, must be at least 8 characters");
            }
            else if (register_password.Length > 20)
            {
                Console.WriteLine("Invalid password, must be less than 20 characters");
            }
            else if (!Regex.IsMatch(register_password, "[A-Z]"))
            {
                Console.WriteLine("Invalid password, must contain at least one uppercase letter");
            }
            else if (!Regex.IsMatch(register_password, "[a-z]"))
            {
                Console.WriteLine("Invalid password, must contain at least one lowercase letter");
            }
            else if (!Regex.IsMatch(register_password, @"\d"))
            {
                Console.WriteLine("Invalid password, must contain at least one digit");
            }
            else if (!Regex.IsMatch(register_password, @"[^\da-zA-Z]"))
            {
                Console.WriteLine("Invalid password, must contain at least one special character");
            }
            else
            {
                Console.WriteLine("Test case Passed!");
            }
            
            
        }

        public static void Main(string[] args)
        {
            BVT bvtInstance = new BVT(); // Creating an instance of the BVT class

            // Loop through each password
            foreach (string password in bvtInstance.passwords)
            {
                bvtInstance.registeration_BV_testing(password); // Call the method for each password
            }
        }
    }
}
