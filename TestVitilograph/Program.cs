using System;
using System.Linq;
using System.Text;

namespace TestVitilograph
{
    class Program
    {
        static void Main(string[] args)
        {

            int shift = 5;
            StringBuilder Output = new StringBuilder();
            string input = GetUserInput();            

                foreach (char c in input)
                {
                    try
                    {
                        //A = 65, Z = 90

                        //Throw exception when not a Capital Letter                   
                        if(c < 65 || c > 90)
                            throw new Exception("Only A-Z supported.");
                    
                        //creates a new variable where 5 is added to the char number
                        int shifted = c + shift;

                        //if the char number is greater than 90 ('Z') then shift from 65 ('A')
                        shifted = shifted > 90 ? 65 + shifted - 91 : shifted;
             
                        //Append shifted char to the string builder
                        //cast the int to a char
                        Output.Append((char)shifted);
                    } catch(Exception e)
                    {
                        Console.WriteLine(c + " Is Not Between A-Z");
                    }
                    
                }
            
            Console.WriteLine("Output: " + Output.ToString());
        }

        public static string GetUserInput()
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please Enter a Value");
                GetUserInput();
            }
                       
            return input;
        }
    }
}
