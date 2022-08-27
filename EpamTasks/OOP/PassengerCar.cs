using System;
using System.Collections.Generic;
using System.Text;
using static EpamTasks.Program;

namespace EpamTasks.OOP
{
    public class PassengerCar:BaseCar
    {
        public PassengerCar(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {

        }
        
        public PassengerCar()
        {

        }
    }
}
