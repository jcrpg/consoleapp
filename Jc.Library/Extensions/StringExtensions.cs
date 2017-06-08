using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Jc.Library.Extensions
{
    /// <summary>
    /// Extension methods for strings 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Appends a string to the end of this string instance, using the supplied delimiter. 
        /// </summary>
        /// <param name="text">The string instance.</param>
        /// <param name="searchText">The string value that will be the search keyword</param>
        /// <param name="options">The RegexOptions configure ignorecase, compiled , none etc.</param>
        /// <returns>String. The concatenated result.</returns>
        public static string SearchIndexPositions(string text, string searchText,RegexOptions options )
        {
            //int first = text.IndexOf(searchText, opt) + searchText.Length;
            Regex rx = new Regex(searchText, options);

            MatchCollection matches = rx.Matches(text);

            var list = matches.Cast<Match>().Select(m => m.Index).ToList();

            return string.Join(",", list).Length ==0?null: string.Join(",", list);
        }
    }
}
