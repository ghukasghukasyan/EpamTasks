using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.InterfaceAndAbstractClass
{
    interface IFlyable
    {
         void FlyTo(Cordinates newPoint);
         void GetFlyTime(Cordinates newPoint);
    }
}
