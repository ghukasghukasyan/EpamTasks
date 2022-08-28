using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    class Bird : IFlyable
    {
        public int speed = 10;
        Cordinates currentPosition = new Cordinates(10, 10, 10);
        
        public void FlyTo(Cordinates newPosition)
        {
           
            Console.WriteLine(" The distance between this two points is ");
            var distance = Math.Sqrt(Math.Pow((newPosition.X - currentPosition.X), 2) + Math.Pow((newPosition.Y - currentPosition.Y), 2) + Math.Pow((newPosition.Z - currentPosition.Z), 2));
            Console.WriteLine(distance);

        }

        public void GetFlyTime(Cordinates newPosition)
        {
            
        }


        

       
        
    }
}
