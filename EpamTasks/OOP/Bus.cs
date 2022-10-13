using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.OOP
{
    public class Bus:Vehicle
    {
        public string Type { get; set; }
        
        public Bus(string type):base()
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Your {this.GetType().Name} Car Info! \n" +
                   $"Type   | {this.Type} bus \n" +
                   $"Engine | Power = {Engine.Power}  Volume = {Engine.Volume}  Serial Number = {Engine.SerialNumber}  Type = {Engine.Type} \n" +
                   $"Transmission | Manufacturer = {Transmission.Manufacturer}  Number Of Gears = {Transmission.NumberOfGears} Type = {Transmission.Type}\n" +
                   $"Chassis | Number = {Chassis.Number} Permissible Load ={Chassis.PermissibleLoad}  Wheels Number= {Chassis.WheelsNumber}";
        }

    }
}
