using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    public class Cordinates
    {

        public int X { get; set; }
        
        
        public int Y { get; set; }
        
        public int Z { get; set; }
        

        public Cordinates(int x,int y,int z)
        {
            X = x;
            Y = y;
            Z = z;
           
           
        }

        public Cordinates()
        {

        }
    }
}
