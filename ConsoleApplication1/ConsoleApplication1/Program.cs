using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        static string Search(string[][] strDoubleDimArray, string searchKey)
        {
            string foundStr = null;
            foreach (string[] eachStrSingleDimArray in strDoubleDimArray)
            {
                foundStr = Array.Find(eachStrSingleDimArray, eachElement => eachElement.Equals(searchKey, StringComparison.CurrentCultureIgnoreCase));

                if (!string.IsNullOrEmpty(foundStr))
                    break;
            }

            return foundStr;
        }

        static string SearMe(String[][] doublearray, string value)
        {
            
            string foundstr = Enumerable
    .Range(0, doublearray.GetLength(0))
    .Where(i => doublearray[i, 0] == value)
    .Select(i => doublearray[i, 1])
    .FirstOrDefault() ?? value;
            return foundstr;
        }

        private static void Main()
        {
            string[][] textArray = new string[][] { new string[] { "apple", "bat" }, new string[] { "cat", "dog" } };
            string foundKey = Search(textArray, "bat");
            Console.WriteLine(string.Format("found: {0}", foundKey));
            Console.Read();
        }
    }
}