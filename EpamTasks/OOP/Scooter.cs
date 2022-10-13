using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.OOP
{
    class Scooter : Vehicle
    {
        public string BrakingSystem { get; set; }
        
        public Scooter(string brakingSystem):base()
        {
            BrakingSystem = brakingSystem;
        }
        public override string ToString()
        {
            return $"Your {this.GetType().Name} Car Info! \n" +
                   $"Braking system | {this.BrakingSystem}  \n" +
                   $"Engine | Power = {Engine.Power}  Volume = {Engine.Volume}  Serial Number = {Engine.SerialNumber}  Type = {Engine.Type} \n" +
                   $"Transmission | Manufacturer = {Transmission.Manufacturer}  Number Of Gears = {Transmission.NumberOfGears} Type = {Transmission.Type}\n" +
                   $"Chassis | Number = {Chassis.Number} Permissible Load ={Chassis.PermissibleLoad}  Wheels Number= {Chassis.WheelsNumber}";
        }
    }
}
