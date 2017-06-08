using System;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jc.Library.Extensions;

namespace Jc.UnitTest.Test
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void TestRegexMatch()
        {
            string text =" Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";

            string searchKeyword = "polly";

            RegexOptions options = RegexOptions.IgnoreCase;

            var result = StringExtensions.SearchIndexPositions(text, searchKeyword, options);


            Assert.IsNotNull(result);

        }
    }
}
