using EpamTasks.OOP;

namespace EpamTasks
{


    public class Engine
    {
        public int Power { set; get; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        public Engine()
        {
           
        }

        public Engine(int power, int volume, string type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }


    }
}
