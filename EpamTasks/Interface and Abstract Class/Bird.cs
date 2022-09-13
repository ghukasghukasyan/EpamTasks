using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.InterfaceAndAbstractClass
{
    public class Bird : AbstractMovableObject
    {
        private int speed = 15;

      


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
            Console.WriteLine("The distance between this two points is : " + distance +" KM");
            var flyTime = distance / speed;
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
