using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    public class Cordinates
    {

        private int x { get; set; }
        private int y { get; set; }
        private int z { get; set; }

        public int X
        {
            get => x;
            set
            {
                if (value < 0)
                { 
                    Console.WriteLine("Insert an positive number for X cordinate"); 
                }
                else
                {
                    value = x;
                }
                            }
        }

        public int Y
        {
            get => y;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Insert an positive number for Y cordinate");
                }
                else
                {
                    value = y;
                }
            }
        }
        
        public int Z
        {
            get => z;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Insert an positive number for Z cordinate");
                }
                else
                {
                    value = z;
                }
            }
        }
        
        public Cordinates()
        {

        }

        public Cordinates(int x,int y,int z)
        {
            X = x;
            Y = y;
            Z = z;
           
           
        }


       
    }
}
