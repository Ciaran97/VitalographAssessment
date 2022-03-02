using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TestVitilograph
{
    class Program
    {
        static void Main(string[] args)
        {
            //All the code could be run from the main method but for maintainability and cleaner code i have broken it into separate functions.
            int Shift = 5;
            
            Console.Write("Input: ");
            string Input = Console.ReadLine();
            //Catch exceptions instead of terminating the application.
            try
            {
                //Use REGEX to determine if input is empty / null or if the string contains any characters that are not A-Z
                //before the application enters the loop.
                 if(Regex.IsMatch(Input, "[^A-Z]|(^$)"))
                    throw new Exception("Only A-Z supported.");
            
                Console.WriteLine("Output: " + ShiftCharacters(Input, Shift));

            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }

        /// <summary>
        /// Shifts letters of a string
        /// </summary>
        /// <param name="Input">String to shift</param>
        /// <param name="Shift">Number of letters to shift</param>
        /// <returns>Shifted string</returns>
        public static string ShiftCharacters(string Input, int Shift)
        {
            //string builder can be faster than concatenation depending on the number of elements.
            StringBuilder Output = new();

            foreach (char Character in Input)
            {
                //if the char number is greater than 90 ('Z') then shift from 65 ('A')
                //The below shortens all the code into one line but makes it more difficult to read, understand and maintain.
                //int Shifted = Character + Shift > 90 ? Character + Shift + 65 - 91 : Character + Shift;

                //Below is a more readable and understandable approach
                //int Shifted = Character + Shift;

                //A = 65, Z = 90
                //Shifted = Shifted > 90 ? 65 + Shifted - 91 : Shifted;

                char A = 'A';

                //Adds the key to the character and subtracts the 'A' character. 
                //Get the division remainder and add 'A' back to the remainder value. 
                int NewShifted = ((Character + Shift - A) % 26) + A;

                //Append shifted char to the string builder
                //cast the int to a char
                Output.Append((char)NewShifted);


            }
            return Output.ToString();
        }

    }
}
