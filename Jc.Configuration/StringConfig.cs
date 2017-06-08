using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Jc.Configuration
{
    public class StringConfig
    {
        /// <summary>
        /// configuration for keywoards
        /// </summary>
        public static string[] SearchString
        {
            get
            {
                string searchStrings = ConfigurationManager.AppSettings["Search.Keywords"];
                return searchStrings.Split(',').Select(u => u.Trim()).ToArray();
            }
        }

        /// <summary>
        /// Configuration for input text
        /// </summary>
        public static string InputString
        {
            get
            {
                string searchStrings = ConfigurationManager.AppSettings["Search.String"];
                return searchStrings;
            }
        }
    }
}
