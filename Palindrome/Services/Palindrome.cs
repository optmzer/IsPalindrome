using System;
using System.Collections.Generic;

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
            string toTest = Word.Replace(" ", "").ToLower();

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
