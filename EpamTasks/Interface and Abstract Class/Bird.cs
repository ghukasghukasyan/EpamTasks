using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.Interface_and_Abstract_Class
{
    class Bird : IFlyable
    {
        private int speed = 10;
        public Cordinates CurrentPosition;
        
        
        public void FlyTo(Cordinates newPosition)
        {
           
            var distance = Math.Sqrt(Math.Pow((newPosition.X - CurrentPosition.X), 2) + Math.Pow((newPosition.Y - CurrentPosition.Y), 2) + Math.Pow((newPosition.Z - CurrentPosition.Z), 2));
            Console.WriteLine("The distance between this two points is : " +distance);
            

        }

        public void GetFlyTime(Cordinates newPosition)
        {
            var distance = Math.Sqrt(Math.Pow((newPosition.X - CurrentPosition.X), 2) + Math.Pow((newPosition.Y - CurrentPosition.Y), 2) + Math.Pow((newPosition.Z - CurrentPosition.Z), 2));
            Console.WriteLine("The distance between this two points is : " + distance);
            var flyTime = distance / speed;
            Console.WriteLine("The fly time is : " +flyTime);
           
        }

        public Bird()
        {

        }

        public Bird(Cordinates currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public override string ToString()
        {
            return $"Bird Cordinates are X = {CurrentPosition.X} Y = {CurrentPosition.Y} Z = {CurrentPosition.Z}";
        }




    }
}
