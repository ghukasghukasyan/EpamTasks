using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks
{
    class Basic
    {
       

        public static void Converters()
        {
            Console.WriteLine ("Insert an integer for converting");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a base number 2-20");
            int system = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(num, system);
            Console.WriteLine($"{num} converted to {system} numeral system equals to {binary}");


        }
    }
}
