using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpamTasks.DevelopmentAndBuildTools
{
    public class MaxCharacter
    {
        public static void LongestSubstringWithNoRepeatingCharacters()
        {
            Console.WriteLine("Insert a string");
            string input = Console.ReadLine();
            List<char> chars = new List<char>();
            int i = 0;
            int j = 0;
            int max = 0;
            while (j < input.Length)
            {
                if (chars.Contains(input[j]))
                {
                    chars.Remove(input[i]);
                    i++;
                }
                else
                {
                   
                    chars.Add(input[j]);
                    j++;
                    max = Math.Max(chars.Count(), max);
                }
            }
            Console.WriteLine($"The maximum number of unequal consecutive characters equal to: "+max);
        }
        
    }
}
