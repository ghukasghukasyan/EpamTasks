using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.OOP
{
    public class Truck:Vehicle
    {
        public string PickUpType { get; set; }
        
        public Truck(string pickUpType):base()
        {
            PickUpType = pickUpType;
        }

        public override string ToString()
        {
            return $"Your {this.GetType().Name} Car Info! \n" +
                   $"Pick up type | {this.PickUpType}  \n" +
                   $"Engine | Power = {Engine.Power}  Volume = {Engine.Volume}  Serial Number = {Engine.SerialNumber}  Type = {Engine.Type} \n" +
                   $"Transmission | Manufacturer = {Transmission.Manufacturer}  Number Of Gears = {Transmission.NumberOfGears} Type = {Transmission.Type}\n" +
                   $"Chassis | Number = {Chassis.Number} Permissible Load ={Chassis.PermissibleLoad}  Wheels Number= {Chassis.WheelsNumber}";
        }
    }
}
