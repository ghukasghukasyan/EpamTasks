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
            List<char> c = new List<char>();
            int i = 0;
            int j = 0;
            int max = 0;
            while (j < input.Length)
            {
                if (c.Contains(input[j]))
                {
                    c.Remove(input[i]);
                    i++;
                }
                else
                {
                   
                    c.Add(input[j]);
                    j++;
                    max = Math.Max(c.Count(), max);
                }
            }
            Console.WriteLine($"The maximum number of unequal consecutive characters equal to: "+max);
        }
        
    }
}
