using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    class Drone : IFlyable
    {
        
        Cordinates currentPosition { get; set; }
        public void FlyTo(Cordinates newPosition)
        {
            Console.WriteLine("The distance between this to points is");
            var distance = Math.Sqrt(Math.Pow((newPosition.X - currentPosition.X), 2) + Math.Pow((newPosition.Y - currentPosition.Y), 2) + Math.Pow((newPosition.Z - currentPosition.Z), 2));


        }

        public void GetFlyTime(Cordinates newPosition)
        {
            
        }

        
    }
}
