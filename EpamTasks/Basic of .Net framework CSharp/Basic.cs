using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks
{
    public class Basic
    {
        public static void Converters()
        {
            Console.WriteLine("Insert an integer for converting");         
            int number = Convert.ToInt32(Console.ReadLine());
            
            int input = number;
            
            Console.WriteLine("Insert a base number 2-20");
            int numberSystem = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, string> numWord = new Dictionary<int, string>()
            {{0, "0"}, {1,"1"},{2,"2"},{3,"3"},{4,"4"},{5,"5"},{6,"6"},{7,"7"},{8,"8"},{9,"9"},{10,"A"},{11,"B"},{12,"C"},{13,"D"},{14,"E"},
            {15,"F"},{16,"G"},{17,"H"},{18,"I"},{19,"J"}};

            StringBuilder str = new StringBuilder();
            
            while (number > 0)
            {
                int reminder = number % numberSystem;
                str.Append(numWord[reminder]);
                number = number / numberSystem;
            }
            
            Console.WriteLine($"Number {input} converted to {numberSystem} numeral system equal to");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

        }
    }
}
