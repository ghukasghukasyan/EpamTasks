using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.OOP
{
    public class Vehicle
    {

        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Chassis Chassis { get; set; }

        public Vehicle()
        {
        }


        public override string ToString()
        {
            return $"Your {this.GetType().Name} Car Info! \n"+ 
                   $"Engine | Power = {Engine.Power}  Volume = {Engine.Volume}  Serial Number = {Engine.SerialNumber}  Type = {Engine.Type} \n" +
                   $"Transmission | Manufacturer = {Transmission.Manufacturer}  Number Of Gears = {Transmission.NumberOfGears} Type = {Transmission.Type}\n" +
                   $"Chassis | Number = {Chassis.Number} Permissible Load ={Chassis.PermissibleLoad}  Wheels Number= {Chassis.WheelsNumber}";
        }
    }
}
