using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool result;

            try
            {
                Console.Write("Input a word to test if its a palindrome: ");
                userInput = Console.ReadLine();

                result = Palindrome.IsPalindrome(userInput);
                if (result == true)
                {
                    Console.WriteLine("The word is a Palindrome. \n");
                }
                else
                {
                    Console.WriteLine("The word is NOT a Palindrome. \n");
                }

                do
                {
                    Console.Write("Enter another word to test or type Exit to end: ");
                    userInput = Console.ReadLine();

                    if (userInput == "Exit")
                    {
                        break;
                    }

                    result = Palindrome.IsPalindrome(userInput);
                    if (result == true)
                    {
                        Console.WriteLine("The word is a Palindrome. Press enter to contiune. \n");
                    }
                    else
                    {
                        Console.WriteLine("The word is NOT a Palindrome. Press enter to contiune. \n");
                    }
                } while (userInput != "Exit");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please contact System Administrator");
            }
        }
    }
}
