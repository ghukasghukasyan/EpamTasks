using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    interface IFlyable
    {
         void FlyTo(Cordinates newPoint);
         void GetFlyTime(Cordinates newPoint);
    }
}
