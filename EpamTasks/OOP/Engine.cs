using EpamTasks.OOP;
using System;

namespace EpamTasks
{


    public class Engine
    {
        private int power { set; get; }
        private double volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        public int Power
        {
            get { return power; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The power can't be negative");
                }
                else
                {
                    this.power = value;
                }
            }
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The volume can't be negative");
                }
                else
                {
                    this.volume = value;
                }
            }
        }
        
        public Engine()
        {   
        }
    }
}
