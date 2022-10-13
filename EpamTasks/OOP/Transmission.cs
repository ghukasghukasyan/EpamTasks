using EpamTasks.OOP;
using System;

namespace EpamTasks
{


    public class Transmission
    {
        private int numberOfGears;

        public string Type { get; set; }
        public string Manufacturer { get; set; }

        public int NumberOfGears
        {
            get

            { return numberOfGears; }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Number of gears can't be negative ");
                }
                else
                {
                    this.numberOfGears = value;
                }
            }
        }

        public Transmission()
        {
        }
    }
}
