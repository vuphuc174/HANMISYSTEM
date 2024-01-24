using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HANMISYSTEM.Common
{
    internal class StringHelper
    {
        public static bool ContainsSpecialCharacters(string input)
        {
            // Define a regex pattern to match special characters
            string pattern = @"[^a-zA-Z0-9\s]";

            // Use Regex.IsMatch to check if the input string contains special characters
            return Regex.IsMatch(input, pattern);
        }
    }
}
