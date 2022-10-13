using EpamTasks.OOP;
using System;

namespace EpamTasks
{


    public class Chassis
    {
        private int wheelsNumber;

        
        public int Number { get; set; }
        public int PermissibleLoad { get; set; }

        public int WheelsNumber
        {
            get { return wheelsNumber; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wheels number can't be negative");
                }
                else
                {
                    this.wheelsNumber = value;
                }
            }
        }
        
        public Chassis()
        {
        }
    }
}
