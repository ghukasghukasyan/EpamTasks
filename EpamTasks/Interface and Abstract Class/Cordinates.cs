using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    public class Cordinates
    {

        private int _x;
        private int _y;
        private int _z;

        public int X
        {
            get { return _x; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Insert an positive number for X cordinate");

                }
                else
                {
                    this._x= value;
                }

            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Insert an positive number for Y cordinate");
                }
                else
                {
                    this._y = value;
                }
            }
        }

        public int Z
        {
            get { return _z; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Insert an positive number for Z cordinate");
                }
                else
                {
                    this._z = value;
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
            return $"X={_x} Y={_y} Z={_z}";
        }


    }
}
