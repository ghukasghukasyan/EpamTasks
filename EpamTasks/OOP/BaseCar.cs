using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.OOP
{
    public class BaseCar
    {

        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Chassis Chassis { get; set; }

        public BaseCar()
        {

        }

        public BaseCar(Engine engine, Transmission transmission, Chassis chassis)
        {
            Engine = engine;
            Transmission = transmission;
            Chassis = chassis;
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
