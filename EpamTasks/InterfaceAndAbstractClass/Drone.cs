using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.InterfaceAndAbstractClass
{
    public class Drone : AbstractMovableObject
    {
        private int speed = 5;

        public override void FlyTo(Cordinates newPosition)
        {
            double distance = this.Distance(newPosition);
            if (distance > 1000)
            {
                Console.WriteLine("Airplane couldn't fly more than 1,000km");
            }
            else
            {
                Console.WriteLine("The distance between this two points is : " + distance);
            };
        }

        public override void GetFlyTime(Cordinates newPosition)
        {
            double distance = this.Distance(newPosition);
            Console.WriteLine("The distance between this two points is : " + distance);
            var flyTime = distance / speed*0.9;
            Console.WriteLine("The fly time is : " + flyTime);
        }

        public Drone()
        {
        }

        public Drone(Cordinates currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public override string ToString()
        {
            return $"Bird Cordinates are X = {CurrentPosition.X}, Y = {CurrentPosition.Y}, Z = {CurrentPosition.Z}";
        }
    }
}
