using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpamTasks.Development_and_build_tools
{
    class MaxCharacter
    {
        public static void LongestSubstringWithNoRepeatingCharacters()
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            List<char> c = new List<char>();
            int iPointer = 0;
            int jpointer = 0;
            int max = 0;
            while (jpointer < s.Length)
            {
                if (c.Contains(s[jpointer]))
                {
                    c.Remove(s[iPointer]);
                    iPointer++;
                }
                else
                {
                   
                    c.Add(s[jpointer]);
                    jpointer++;
                    max = Math.Max(c.Count(), max);
                }
            }
            Console.WriteLine(max);
        }
        
    }
}
