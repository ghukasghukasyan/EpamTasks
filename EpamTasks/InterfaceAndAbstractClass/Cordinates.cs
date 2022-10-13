using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.InterfaceAndAbstractClass
{
    public struct Cordinates
    {
        public int X;
        public int Y;
        public int Z;

        public Cordinates(int x, int y, int z)
        {
            if (x < 0)
            {
                throw new Exception("X cordinate should be positive");
            }
            else
            {
                this.X = x;
            }
           
            if (y < 0)
            {
                throw new Exception("Y cordinate should be positive");
            }
            else
            {
                this.Y = y;
            }
            
            if (z < 0)
            {
                throw new Exception("Z cordinate should be positive");
            }
            else
            {
                this.Z= z;
            }
        }

        public override string ToString()
        {
            return $"X={X} Y={Y} Z={X}";
        }


    }
}
