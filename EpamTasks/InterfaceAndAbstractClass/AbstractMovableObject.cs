using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.InterfaceAndAbstractClass
{
    public abstract class AbstractMovableObject : IFlyable
    {
        public abstract void FlyTo(Cordinates newPoint);
        public abstract void GetFlyTime(Cordinates newPoint);
        public Cordinates CurrentPosition { get; set; }

        public double Distance(Cordinates newPosition)
        {
            double distance = Math.Sqrt(Math.Pow((newPosition.X - CurrentPosition.X), 2) + Math.Pow((newPosition.Y - CurrentPosition.Y), 2) + Math.Pow((newPosition.Z - CurrentPosition.Z), 2));
            return distance;
        }
    }
}

