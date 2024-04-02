using System;
using System.Collections.Concurrent;
using System.Linq;
using LINQExample_1;

namespace LinqExample
{
    public class LinqMainClass
    {
        static void Main(string[] args)
        {
            var wordNoUpperCase = new string[] {"blue","red","pink" };
            Console.WriteLine(IsAnyWordUpperCase(wordNoUpperCase));

            var wordWithUpperCase = new string[] { "BLUE", "red", "PINK" };
            Console.WriteLine(IsAnyWordUpperCase(wordWithUpperCase));

            var orderdwords= wordNoUpperCase.OrderBy(x => x);

            Console.ReadKey();
        }

        public static bool IsAnyWordUpperCase_Linq(
            IEnumerable<string> words)
        {
            return words.Any(word=>
            
            word.All(letter=>char.IsUpper(letter)));
        }

        public static bool IsAnyWordUpperCase(IEnumerable<string> words) {

            foreach (var word in words) 
            {
                bool areAllUpperCase = true;
                foreach (var letter in word)
                {
                    if (char.IsLower(letter))
                    { 
                        areAllUpperCase = false;
                    }
                    if (areAllUpperCase) {
                        return true;
                    }
                }
            }
            return false;
        }

    }

}