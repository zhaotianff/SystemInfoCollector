using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SystemInfoCollector.Util
{
    internal static class StringRegexExtension
    {
        public static string ExtractDigit(this string input)
        {
            var pattern = "\\d+";
            var match = Regex.Match(input, pattern);
            if (match.Success)
                return match.Value;

            return input;
        }
    }
}
