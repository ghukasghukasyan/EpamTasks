using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    class Airplane : IFlyable
    {

        private readonly int initialSpeed = 200;
        Cordinates CurrentPosition { get; set; }

        
        public void FlyTo(Cordinates newPosition)
        {
            
            var distance = Math.Sqrt(Math.Pow((newPosition.X - CurrentPosition.X), 2) + Math.Pow((newPosition.Y - CurrentPosition.Y), 2) + Math.Pow((newPosition.Z - CurrentPosition.Z), 2));
            if (distance > 10000)
            {
                Console.WriteLine("Airplane couldn't fly more than 10,000km");
            }
            else
            {
                Console.WriteLine("The distance between this two points is : " + distance);
            };


        }


        public void GetFlyTime(Cordinates newPosition)
        {
            var distance = Math.Sqrt(Math.Pow((newPosition.X - CurrentPosition.X), 2) + Math.Pow((newPosition.Y - CurrentPosition.Y), 2) + Math.Pow((newPosition.Z - CurrentPosition.Z), 2));
            if (distance > 10000)
            {
                Console.WriteLine("Airplane couldn't fly more than 10,000km");
            }
            else
            {
                Console.WriteLine("The distance between this two points is : " + distance);

            };
            int currentSpeed = initialSpeed + (int)distance / 10;
            var flyTime = distance / currentSpeed;
            Console.WriteLine("The fly time is : " + flyTime);

        }

        public Airplane()
        {

        }

        public Airplane(Cordinates currentPosition)
        {
            CurrentPosition = currentPosition;
        }
        public override string ToString()
        {
            return $"Airplane Cordinates are X = {CurrentPosition.X}, Y = {CurrentPosition.Y}, Z = {CurrentPosition.Z}";
        }


    }
}
