using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.InterfaceAndAbstractClass
{
    public class Airplane : AbstractMovableObject
    {
        public override void FlyTo(Cordinates newPosition)
        {
            double distance = this.Distance(newPosition);

            if (distance > 10000)
            {
                Console.WriteLine("Airplane couldn't fly more than 10,000km");
            }
            else
            {
                Console.WriteLine($"The distance between this two points is : { distance} KM");
            };
        }

        public override void GetFlyTime(Cordinates newPosition)
        {
            double distance =this.Distance(newPosition);
            if (distance > 10000)
            {
                Console.WriteLine("Airplane couldn't fly more than 10,000km");
            }
            else
            {
                Console.WriteLine($"The distance between this two points is :  {distance} km");
                int sections = (int)distance / 10;
                float flyTime = 0;
                int adding = 10;

                for (int i = 0; i < sections; i++)
                {

                    flyTime += 10 / (205f + adding * i);
                }
                
                if (distance - (sections * 10) == 0)
                {
                    Console.WriteLine($"The flight time is equal to {flyTime} hour");
                }
                else
                {
                    Console.WriteLine($"The flight time is equal to "+((distance - (sections * 10)) / (205f + (10 * sections))) +" hour");
                }
            };
        }

        public Airplane()
        {
        }

        public Airplane(Cordinates currentPosition)
        {
            this.CurrentPosition = currentPosition;
        }
        
        public override string ToString()
        {
            return $"Airplane Cordinates are X = {CurrentPosition.X}, Y = {CurrentPosition.Y}, Z = {CurrentPosition.Z}";
        }


    }
}
