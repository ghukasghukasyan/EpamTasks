using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    class Bird : IFlyable
    {
        public void FlyTo()
        {

            
        }

        public void GetFlyTime()
        {
            throw new NotImplementedException();
        }

        Cordinates currentPosition { get; set; }
        Cordinates  newPosition{ get; set; }
        int speed = 10;
        int space = 200;
    }
}
