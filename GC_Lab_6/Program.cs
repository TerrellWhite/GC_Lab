using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GC_Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            try
            {
                do
                {

                    int sides = GetVaildNumInput(@"^\d{1,2}", "How many sides to the dice?");

                    Random rnd = new Random();
                    int dice = rnd.Next(1, sides);
                    int dice2 = rnd.Next(1, sides);
                    Console.WriteLine($"{dice} and {dice2}");
                    ans = GetVaildInput(@"^[yY]|[nN]{1}$", "Wanna go again (y/n)");



                } while (ans.ToLower() == "y");
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Stop trying to break my code Drew!");
            }
        }
        public static int GetVaildNumInput(string pattern, string userMessage, string errorMessage = "Wrong Input Try Again")
        {
            Console.WriteLine(userMessage);
            string input = Console.ReadLine();
            while (!(Regex.IsMatch(input, pattern)))
            {
                Console.WriteLine(errorMessage);
                input = Console.ReadLine();

            }
 
            return int.Parse(input); 

        }
        public static string GetVaildInput(string pattern, string userMessage, string errorMessage = "Wrong Input Try Again")
        {
            Console.WriteLine(userMessage);
            string input = Console.ReadLine();
            while (!(Regex.IsMatch(input, pattern)))
            {
                Console.WriteLine(errorMessage);
                input = Console.ReadLine();

            }
            return input;
        }
    }
}
