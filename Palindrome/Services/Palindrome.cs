using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Polindrome.Services
{
    public class Palindrome : IPalindrome
    {
        /**
         * Palindrome checker ignore cases.
         * Converts a word into lower case then check if it is a palindrome
         * returns true if it is.
         */ 
        public bool IsPalindrome(string Word)
        {
            //Only match Text and numbers [a-zA-Z0-9]
            MatchCollection match = Regex.Matches(Word.ToLower(), "[a-zA-Z0-9]");
            StringBuilder sb = new StringBuilder();

            //Then rebuild matches in a string
            foreach (var item in match)
            {
                sb.Append(item);
            }
            //string toTest = Word.Replace(" ", "").ToLower();
            string toTest = sb.ToString();


            bool isPalindrome = true;
           
            for(int i = 0, j = toTest.Length - 1; i < ((toTest.Length / 2) + 1); ++i, --j)
            {
                var first = toTest[i];
                var last = toTest[j];

                if (toTest[i].Equals(toTest[j]))
                {
                    //Do nothing
                }
                else
                {
                    return false;
                }
            }

            return isPalindrome;
        }
    }
}
