using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    class Drone : IFlyable
    {
        public void FlyTo()
        {
           
        }

        public void GetFlyTime()
        {
            
        }

        Cordinates CurrentPosition { get; set; }
        Cordinates newPosition { get; set; }
    }
}
