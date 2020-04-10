using System;

namespace ConsoleApp1
{
    class Program
    {

        // Done By thiago Batista - SN 301110966 - Comp 100 winter 2020

        static void Main(string[] args)
        {

            // Here`s the problem at hand:
            // A palindrome is a word, phrase, number or other sequence of units that can be read the same way in either direction. The character palindromes are words that can be read the same way in either direction(radar, civic, sdfds, 1drd1).  The number palindromes are numbers that can be read the same way in either direction(12321, 1221221).
            //[25 points] Write a console application that reads a word and display if it is number palindrome, character palindrome, or not a palindrome at all.The application should ask for a new word until user enters word “end”.  Before exiting application print out the list of all palindrome words that user has input.
            //[60 points] Make the code more readable and non-repetitive by use of the methods.  Your application should have at least one method that is called IsPalindrome that returns true if the provided argument is palindrome.

            //Sollution

            //Lets start by creating the Global Variables that we are going to use

            string UserInput;
            string[] ListPalindrome = new string[0];

            // then lets ask for the user to givec us a variable as save it as a "string"

            Console.WriteLine("A palindrome is a word, phrase, number or other sequence of units that can be read the same way in either direction");
            Console.WriteLine("Lets see if you can think of some Palindromes");
            Console.WriteLine("");
            Console.WriteLine("So please give me an input. It can be a number or word.");
            Console.WriteLine("If it is a Palindrome i`ll say to you and save it.");
            Console.WriteLine("When you want to stop just hit say end");
            UserInput = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");

            //Since if the user input end were done, this is going to be the first statement, otherwise it will keep going in a loop

            while (UserInput != "end")
            {
                if (IsNumeric(UserInput))
                {
                    // If it`s a Numeric value it will go to check if it is a Palindrome (Go for the Method, and then came back here)

                    IsPalindrome(UserInput, ref ListPalindrome);
                }
                else
                {
                    // Otherwise it will check if the character it is a Palindrome (Go for the Method, and then came back here)

                    CharacterPalindrome(UserInput, ref ListPalindrome);
                }

                // Then the loop will continue until the end is presented

                Console.WriteLine("");
                Console.WriteLine("Let`s try this again.");
                Console.WriteLine("Write me a new input");
                UserInput = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
            }

            // When the user says end, it will show only the values that were checked as Palindromes

            Console.WriteLine("Here is a list of your Palindromes:");

            foreach (var item in ListPalindrome)
            {
                Console.WriteLine(item);
            }
        }

        public static void IsPalindrome(string UserInput, ref string[] ListPalindrome) //Since we want only to return the Palindromes, we need to use ref to use this as the new values for the List.
        {
            //then we gonna pick the user input and turn it in individual values that we can compare with the reverse.
            //So first we turn it in these individual values

            char[] ch = UserInput.ToCharArray();

            //Then we reverse the order of these values

            Array.Reverse(ch);

            //And check if the reverse values are equal to the original ones

            string reverse = new string(ch);

            bool b = UserInput.Equals(reverse, StringComparison.OrdinalIgnoreCase);

            //If it is, then we put it in the list of Palindromes and increase the size of the list by one.

            if (b == true)
            {
                Console.WriteLine("" + UserInput + " is a Numeric Palindrome! Let me save it!");
                Array.Resize(ref ListPalindrome, ListPalindrome.Length + 1);
                ListPalindrome[ListPalindrome.GetUpperBound(0)] = UserInput;
            }

            //If it`s not, we just go back to the "new input" part.

            else
            {
                Console.WriteLine("" + UserInput + " is not a Palindrome!");
            }
            return;
        }

        public static void CharacterPalindrome(string UserInput, ref string[] ListPalindrome) // The exact same thing is done here, but checking for characters, instead of numbers. 
        {
            char[] ch = UserInput.ToCharArray();

            Array.Reverse(ch);

            string reverse = new string(ch);

            bool b = UserInput.Equals(reverse, StringComparison.OrdinalIgnoreCase);

            if (b == true)
            {
                Console.WriteLine("" + UserInput + " is a Character Palindrome! Let me save it!");
                Array.Resize(ref ListPalindrome, ListPalindrome.Length + 1);
                ListPalindrome[ListPalindrome.GetUpperBound(0)] = UserInput;
            }

            else
            {
                Console.WriteLine("" + UserInput + " is not a Palindrome!");
            }
            return;
        }


        public static bool IsNumeric(string UserInput)
        {
            // To check if the user input is a number or not, we simple pick every char in the input and test if their value is equal to 0 to 9.
            // If any of these char are a number, we will consider it as a Numeric input, otherwise it will return as a 100% char input.

            foreach (char c in UserInput)
            {
                if
                    (!(c >= '0' && c <= '9'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

    }
}
