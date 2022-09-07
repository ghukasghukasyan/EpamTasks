using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.InterfaceAndAbstractClass
{
    public class Cordinates
    {

        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Insert an positive number for X cordinate");

                }
                else
                {
                    this.x= value;
                }

            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Insert an positive number for Y cordinate");
                }
                else
                {
                    this.y = value;
                }
            }
        }

        public int Z
        {
            get { return z; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Insert an positive number for Z cordinate");
                }
                else
                {
                    this.z = value;
                }
            }
        }

        public Cordinates()
        {
        
        }

        public Cordinates(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public override string ToString()
        {
            return $"X={x} Y={y} Z={z}";
        }


    }
}
