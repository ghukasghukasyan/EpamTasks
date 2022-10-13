using EpamTasks.DevelopmentAndBuildTools;
using EpamTasks.InterfaceAndAbstractClass;
using EpamTasks.OOP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EpamTasks
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter Number for Task Review \n" +
                $"1 - LongestSubstringWithNoRepeatingCharacters \n" +
                $"2 - Converters\n" +
                $"3 - OOP \n" +
                $"4 - Interface and Abstract Class \n" +
                $"5 - Collections \n" );
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            { 
                case 1:
                    Console.WriteLine("Let's see Task #1 Solution \n");
                    MaxCharacter.LongestSubstringWithNoRepeatingCharacters();
                    break;
                
                case 2:
                    Console.WriteLine("Let's see Task #2 Solution \n");
                    Basic.Converters();
                    break;

                case 3: 
                    Console.WriteLine("Let's see Task #3 Solution \n"); 
                    PassengerCar passengerCar = new PassengerCar("Cabriolet")
                    {
                        Engine = new Engine { Power = 123, SerialNumber = "ZHQSA15AQTA153", Type = "V8", Volume = 1000 },
                        Transmission = new Transmission { Manufacturer = "ZF", NumberOfGears = 6, Type = "Automatic" },
                        Chassis = new Chassis { Number = 5, PermissibleLoad = 3000, WheelsNumber = 4 },

                    };

                    Console.WriteLine(passengerCar.ToString() + "\n");


                    Truck truck = new Truck("Full size")
                    {
                        Engine = new Engine { Power = 400, SerialNumber = "ERTHE154DHSA153", Type = "V12", Volume = 5000 },
                        Transmission = new Transmission { Manufacturer = "ZF", NumberOfGears = 15, Type = "Automatic" },
                        Chassis = new Chassis { Number = 10, PermissibleLoad = 23000, WheelsNumber = 10 }
                    };

                    Console.WriteLine(truck.ToString() + "\n");


                    Bus bus = new Bus("School")
                    {
                        Engine = new Engine { Power = 300, SerialNumber = "KDARTHE154DHSA153", Type = "V6", Volume = 5000 },
                        Transmission = new Transmission { Manufacturer = "ZF", NumberOfGears = 7, Type = "Mechanical" },
                        Chassis = new Chassis { Number = 8, PermissibleLoad = 15000, WheelsNumber = 6 }
                    };

                    Console.WriteLine(bus.ToString() + "\n");


                    Scooter scooter = new Scooter("Hand brake")
                    {
                        Engine = new Engine { Power = 100, SerialNumber = "IEYSTH1547SYAH", Type = "V6", Volume = 1000 },
                        Transmission = new Transmission { Manufacturer = "Seado", NumberOfGears = 5, Type = "Automatic" },
                        Chassis = new Chassis { Number = 4, PermissibleLoad = 500, WheelsNumber = 0 }
                    };
                    Console.WriteLine(scooter.ToString() + "\n");
                    break;

                case 4:
                    Console.WriteLine("Let's see Task #4 Solution \n");
                    Console.WriteLine("Insert positive number for X cordinate ");
                    int xCord = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert positive number for Y cordinate ");
                    int yCord = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert positive number for Z cordinate ");
                    int zCord = Convert.ToInt32(Console.ReadLine());


                    Bird bird = new Bird(new Cordinates(xCord, yCord, zCord));
                    Console.WriteLine(bird.ToString());
                    bird.FlyTo(new Cordinates(10, 30, 40));
                    bird.GetFlyTime(new Cordinates(10, 30, 40));

                    Airplane airplane = new Airplane(new Cordinates(xCord, yCord, zCord));
                    Console.WriteLine(airplane.ToString());
                    airplane.FlyTo(new Cordinates(10, 20, 30));
                    airplane.GetFlyTime(new Cordinates(10, 20, 30));
                    break;

                case 5:
                    Console.WriteLine("Let's see Task #5 Solution \n");
                    List<Vehicle> arr = new List<Vehicle>();

                    arr.Add(
                        new PassengerCar("Cabriolet")
                        {
                            Engine = new Engine { Power = 123, SerialNumber = "ZHQSA15AQTA153", Type = "V8", Volume = 2.5 },
                            Transmission = new Transmission { Manufacturer = "ZF", NumberOfGears = 6, Type = "Automatic" },
                            Chassis = new Chassis { Number = 5, PermissibleLoad = 3000, WheelsNumber = 4 },
                        });


                    arr.Add(
                        new Truck("Full size")
                        {
                            Engine = new Engine { Power = 400, SerialNumber = "ERTHE154DHSA153", Type = "V12", Volume = 6.2 },
                            Transmission = new Transmission { Manufacturer = "ZF", NumberOfGears = 15, Type = "Automatic" },
                            Chassis = new Chassis { Number = 10, PermissibleLoad = 23000, WheelsNumber = 10 }
                        });


                    arr.Add(
                        new Bus("Schoo;")
                        {
                            Engine = new Engine { Power = 300, SerialNumber = "KDARTHE154DHSA153", Type = "V6", Volume = 4.7 },
                            Transmission = new Transmission { Manufacturer = "ZF", NumberOfGears = 7, Type = "Mechanical" },
                            Chassis = new Chassis { Number = 8, PermissibleLoad = 15000, WheelsNumber = 6 }
                        });


                    arr.Add(
                        new Scooter("Hand brake")
                        {
                            Engine = new Engine { Power = 100, SerialNumber = "IEYSTH1547SYAH", Type = "V6", Volume = 0.6 },
                            Transmission = new Transmission { Manufacturer = "Seado", NumberOfGears = 5, Type = "Automatic" },
                            Chassis = new Chassis { Number = 4, PermissibleLoad = 500, WheelsNumber = 0 }
                        });



                    var query = arr.Where(arr => arr.Engine.Volume > 1.5).ToList();
                    //var query = from arrs in arr
                    //            where arrs.Engine.Power > 1.5
                    //            select arrs;

                    XElement aer = new XElement("AllInformationAboutAllVehiclesAnEngineCapacityOfWhichIsMoreThan1.5Liters");


                    foreach (var i in query)
                    {
                        aer.Add(new XElement(i.GetType().Name,
                           new XElement("enginePower", i.Engine.Power),
                           new XElement("engineSerialNumber", i.Engine.SerialNumber),
                           new XElement("engineType", i.Engine.Type),
                           new XElement("enginePower", i.Engine.Power),
                           new XElement("transmissionManufacturer", i.Transmission.Manufacturer),
                           new XElement("transmissionNumberOfGears", i.Transmission.NumberOfGears),
                           new XElement("transmissionType", i.Transmission.Type),
                           new XElement("chassisNumber", i.Chassis.Number),
                           new XElement("chassisPermissibleLoad", i.Chassis.PermissibleLoad),
                           new XElement("chassisWheelsNumber", i.Chassis.WheelsNumber)

                           ));

                    }

                    aer.Save("task5.1.xml");
                    Console.WriteLine(aer);


                    var query1 = arr.Where(arr => arr.GetType() == typeof(Truck) || arr.GetType() == typeof(Bus)).ToList();
                    //var query1 = from arrs in arr
                    //             where arrs.GetType() == typeof(Truck) || arrs.GetType() == typeof(Bus)
                    //             select arrs;

                    XElement car = new XElement("EngineTypeSerialNumberAndPowerRatingForAllBusesAndTrucks");
                    foreach (var i in query1)
                    {
                        car.Add(new XElement(i.GetType().Name,
                            new XElement("engineType", i.Engine.Type),
                           new XElement("serialNumber", i.Engine.SerialNumber),
                           new XElement("enginePower", i.Engine.Power)));

                    }

                   
                    car.Save("task5.2.xml");
                    Console.WriteLine(car);

                    var query2 = arr.GroupBy(a => a.Transmission.Type).ToList();
                    //var query2 = from arrs in arr
                    //.GroupBy(arr => arr.Transmission.Type)
                    //select arrs;


                    XElement b = new XElement("AllInformationAboutAllVehiclesGroupedByTransmissionType");

                    foreach (var transmission in query2)
                    {
                       
                        var k = new XElement(transmission.Key);


                        foreach (var baseCar in transmission)
                        {
                            k.Add(new XElement(baseCar.GetType().Name,
                               new XElement("enginePower", baseCar.Engine.Power),
                               new XElement("engineSerialNumber", baseCar.Engine.SerialNumber),
                               new XElement("engineType", baseCar.Engine.Type),
                               new XElement("enginePower", baseCar.Engine.Power),
                               new XElement("transmissionManufacturer", baseCar.Transmission.Manufacturer),
                               new XElement("transmissionNumberOfGears", baseCar.Transmission.NumberOfGears),
                               new XElement("transmissionType", baseCar.Transmission.Type),
                               new XElement("chassisNumber", baseCar.Chassis.Number),
                               new XElement("chassisPermissibleLoad", baseCar.Chassis.PermissibleLoad),
                               new XElement("chassisWheelsNumber", baseCar.Chassis.WheelsNumber)
                               ));

                        }

                        b.Add(k);
                    }

                    b.Save("task5.3.xml");
                    Console.WriteLine(b);
                    break;
            }
        }
    }
}
