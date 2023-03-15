using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Title: Console_Application
 *Author: Cornestean Gheorghe-Mihaita
 * Version: 1.0
 * Date:15.03.2023
 *Description: This is a console application that performs various string manipulation operations.
 */


namespace Console_Application
{
    internal class Program
    {
        static void ConvertUppercase()
        {
            Console.WriteLine("You chose option 1 (Convert a string to uppercase).\n" +
                "Let's type a few words.");
            string str = Console.ReadLine();

            // just using the ToUpper function to convert the string to uppercase

            str = str.ToUpper();
            Console.WriteLine("This is the result: " + str + "\n");
            
        }

        static void Reverse()
        {
            Console.WriteLine("You chose option 2 (Reverse a string).\n" +
                "Let's type a few words.");
            string str = Console.ReadLine();

            // we will concatenate all the elements of our string into a new string starting from the last one and ending with the first one

            string rts = str.Substring(str.Length);

            for (int i = str.Length-1; i >= 0; i--)
                rts=String.Concat(rts, str[i]);

            Console.WriteLine("This is the result: " + rts +  "\n");
        }

        static void NumberOfVowels()
        {
            Console.WriteLine("You chose option 3 (Count the number of vowels in a string).\n" +
                "Let's type a few words.");
            string str = Console.ReadLine();
            string[] vowels = { "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y" };

            // There are apparently a set of rules based on which "y" can be considered either or a vowel or a consonant, but for the sake of simplicity
            // i will consider y a vowel in this context

            int number=0;
            for(int i=0;i<str.Length;i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                    if (str[i].Equals(vowels[j][0]))
                        number++;
            }
            Console.WriteLine("This is the result: " + number + "\n");
        }

        static void NumberOfWords()
        {
            Console.WriteLine("You chose option 4 (Count the number of words in a string).\n" +
                "Let's type a few words.");
            string str = Console.ReadLine();

            // we will be looking for blanks manually and count the number of words based on our findings

            int number = 0;
            if (str[0] != ' ')
                number++;
            
            for (int i=1;i<str.Length;i++)
            {if (str[i] != ' ' && str[i - 1] == ' ')
                    number++;
            }
            
            Console.WriteLine("This is the result: " + number + "\n");
        }

        static void ToTitleCase()
        {
            Console.WriteLine("You chose option 5 (Convert a string to title case).\n" +
                 "Let's type a few words.");
            string str = Console.ReadLine();
            str = str.ToLower();

            // we will be using the function ToTitleCase from the System.Globarization library

            var textinfo = new CultureInfo("en-US", false).TextInfo;
            str=textinfo.ToTitleCase(str);

            /*
              string[] letters = {"a" , "b" , "c" , "d" , "e" , "f" , "g" , "h" , "i" , "j" , "k" , "l" , "m" , "n" , "o" , "p" , "q" , "r" , "s" ,"t" , "u" , "v" ,
             "w" , "x" , "y" , "z"};
            

              for (int i = 0; i < str.Length; i++)
                for(int j=0;j<letters.Length;j++)
                 if (str[i].Equals(letters[j][0]) && str[i - 1] == ' ')
                     ----------------------------------------------------

            //the brute force method i was trying seems to be missing a way to convert the string elements to uppercase 

            */

            Console.WriteLine("This is the result: " + str + "\n");
        }

        
        

        static void Main(string[] args)
        { int i = 1;                       // the program will be running until it is stopped by the user
            while (i != 0)
            { Console.WriteLine("\n Welcome!\n Choose from the following options by typing a number:\n" +
                    "\n1. Convert a string to uppercase" +
                    "\n2. Reverse a string" +
                    "\n3. Count the number of vowels in a string" +
                    "\n4. Count the number of words in a string" +
                    "\n5. Convert a string to title case" +
                    "\n6. Exit application\n");

                string input = Console.ReadLine();
                switch(input)
                {
                    case "1": ConvertUppercase();
                        break;
                    case "2": Reverse();
                            break;
                    case "3": NumberOfVowels();
                            break;
                    case "4": NumberOfWords();
                            break;
                    case "5": ToTitleCase();
                            break;
                    case "6": i = 0;               // here it stops
                            break;
                    default:
                            break;
                }
                
            }
           
        }
    }
}
