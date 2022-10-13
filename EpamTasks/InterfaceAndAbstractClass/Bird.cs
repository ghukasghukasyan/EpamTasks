using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.InterfaceAndAbstractClass
{
    public class Bird : AbstractMovableObject
    {
        Random rnd = new Random();
        private int speed;

        public override void FlyTo(Cordinates newPosition)
        {
            double distance = this.Distance(newPosition);
            if (distance > 100)
            {
                Console.WriteLine("Bird couldn't fly more than 100 KM");
            }
            else
            {
                Console.WriteLine("The distance between this two points is : " + distance +" KM");
            };
        }

        public override void GetFlyTime(Cordinates newPosition)
        {
            double distance = this.Distance(newPosition);
            Console.WriteLine("The distance between this two points is : " + distance + " KM");
            speed = rnd.Next(1, 20);
            var flyTime = distance / speed;
            Console.WriteLine($"The speed of bird equal to: {speed}");

            Console.WriteLine("The fly time is : " + flyTime+ " hour");
        }

        public Bird()
        {
        }

        public Bird(Cordinates currentPosition)
        {
            this.CurrentPosition = currentPosition;
        }

        public override string ToString()
        {
            return $"Bird Cordinates are X = {CurrentPosition.X}, Y = {CurrentPosition.Y}, Z = {CurrentPosition.Z}";
        }
    }
}
