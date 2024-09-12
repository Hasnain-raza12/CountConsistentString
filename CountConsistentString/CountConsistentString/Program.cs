using System;
using System.Collections.Generic;

namespace CountConsistentString
{
    public class Solution
    {

        public int CountConsistentString(string allowed, string[] words)
        {
            HashSet<char> allowedSet = new HashSet<char>(allowed);
            int consistentCount = 0;
            foreach (string word in words)
            {
                bool isConsistent = true;
                foreach (char c in word)
                {
                    if (!allowedSet.Contains(c))
                    {
                        isConsistent = false;
                        break;
                    }

                }
                if (isConsistent)
                {
                    consistentCount++;
                }
            }
            return consistentCount;
        }


    }
    public class Program
    {
        static void Main(string[] args)
        {
            /*You are given a string allowed consisting of distinct characters and an array of strings words.
              A string is consistent if all characters in the string appear in the string allowed.
              Return the number of consistent strings in the array words. 

              Example 1:

                 Input: allowed = "ab", words = ["ad","bd","aaab","baa","badab"]
                 Output: 2
                 Explanation: Strings "aaab" and "baa" are consistent since they only contain characters 'a' and 'b'.

              Example 2:

                 Input: allowed = "abc", words = ["a","b","c","ab","ac","bc","abc"]
                 Output: 7
                 Explanation: All strings are consistent.

               Example 3:

                 Input: allowed = "cad", words = ["cc","acd","b","ba","bac","bad","ac","d"]
                 Output: 4
                 Explanation: Strings "cc", "acd", "ac", and "d" are consistent.

              */


            Solution solution = new Solution();
            string allowed1 = "ab";
            string[] words1 = { "ad", "bd", "aaab", "baa", "badab" };
            Console.WriteLine(solution.CountConsistentString(allowed1, words1));


            string allowed2 = "abc";
            string[] words2 = { "a", "b", "c", "ab", "ac", "bc", "abc" };
            Console.WriteLine(solution.CountConsistentString(allowed2, words2));


            string allowed3 = "cad";
            string[] words3 = { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" };
            Console.WriteLine(solution.CountConsistentString(allowed3, words3));
        }
    }
}
