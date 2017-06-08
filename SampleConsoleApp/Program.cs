using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Jc.Configuration;
using Jc.Library.Extensions;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!string.IsNullOrEmpty(StringConfig.InputString))
            {
                string input = StringConfig.InputString;

                Console.WriteLine("Enter 'end' to exist....");

                Console.WriteLine("Text:" + input);
                string searchString = string.Empty;
                Console.Write("Enter your Subtext:(you can keep trying different combination to see the index position on the above Text)");

                while ((searchString = Console.ReadLine()) != "end")
                {
                    Console.WriteLine(StringExtensions.SearchIndexPositions(input,searchString,RegexOptions.IgnoreCase)??"<no matches>");

                }


            }
        }
    }
}
