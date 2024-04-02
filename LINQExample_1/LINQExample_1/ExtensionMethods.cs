using LinqExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample_1
{
    public class ExtensionMethods : LinqMainClass
    {
        static void Extentions()
        {
            var word = new[] {"a","bb","ccc","dddd" };
            var wordsLongerThan2Letters = word.Where(word=>word.Length > 2);

            Console.WriteLine(string.Join(",", wordsLongerThan2Letters));
            Console.ReadKey();
        } 
    }
}
