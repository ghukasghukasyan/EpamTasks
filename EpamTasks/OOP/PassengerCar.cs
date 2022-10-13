using System;
using System.Collections.Generic;
using System.Text;
using static EpamTasks.Program;

namespace EpamTasks.OOP
{
    public class PassengerCar:Vehicle
    {   
        public string TypeOfBody { get; set; }
        
        public PassengerCar(string typeOfbody): base()
        {
            TypeOfBody = typeOfbody;
        }

        public override string ToString()
        {
            return $"Your {this.GetType().Name} Car Info! \n" +
                   $"Type of body | {TypeOfBody}  \n" +
                   $"Engine | Power = {Engine.Power}  Volume = {Engine.Volume}  Serial Number = {Engine.SerialNumber}  Type = {Engine.Type} \n" +
                   $"Transmission | Manufacturer = {Transmission.Manufacturer}  Number Of Gears = {Transmission.NumberOfGears} Type = {Transmission.Type}\n" +
                   $"Chassis | Number = {Chassis.Number} Permissible Load ={Chassis.PermissibleLoad}  Wheels Number= {Chassis.WheelsNumber}";
        }
    }
}
