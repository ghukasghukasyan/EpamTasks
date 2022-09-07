using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTasks.OOP
{
    public class Bus:BaseCar
    {
        public Bus()
        {

        }

        public Bus(Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {

        }
    }
}
