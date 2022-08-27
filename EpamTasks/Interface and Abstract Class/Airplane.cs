using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    class Airplane : IFlyable
    {
        public void FlyTo()
        {
            throw new NotImplementedException();
        }
        

        public void GetFlyTime()
        {
            throw new NotImplementedException();
        }

        Cordinates CurrentPosition { get; set; }
        int initialSpeed = 200;
       

    }
}
