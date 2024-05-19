using System.Diagnostics.Tracing;

namespace StringWithoutSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Code Academy";
            Console.WriteLine(RemoveSpace(word));
        }

        static string RemoveSpace(string input)
        {
            
            string result = "";

            foreach (char c in input) 
            {
                if (c != ' ')
                { 
                  result += c;

                }
                           
            
            }

            return result;

            
        }
    }
}
