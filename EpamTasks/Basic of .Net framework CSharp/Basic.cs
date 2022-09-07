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

            StringBuilder str = new StringBuilder();

            int reminder;
            while (number > 0)
            {
                reminder = number % numberSystem;
                if (reminder == 10)
                {
                    str.Append("A");
                }
                else if (reminder == 11)
                {
                    str.Append("B");
                }
                else if (reminder == 12)
                {
                    str.Append("C");
                }
                else if (reminder == 13)
                {
                    str.Append("D");
                }
                else if (reminder == 14)
                {
                    str.Append("E");
                }
                else if (reminder == 15)
                {
                    str.Append("F");
                }
                else
                    str.Append(reminder);
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
