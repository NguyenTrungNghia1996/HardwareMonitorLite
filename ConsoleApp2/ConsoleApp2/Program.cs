using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }
        static void Main(string[] args)
        {

            Computer computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMemoryEnabled = true,
                IsMotherboardEnabled = true,
                IsControllerEnabled = true,
                IsNetworkEnabled = true,
                IsStorageEnabled = true
            };

            computer.Open();
            computer.Accept(new UpdateVisitor());
            var ListDisk = new List<diskDrive>();
            
            foreach (IHardware hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Storage)
                {
                    Console.WriteLine("Hardware: {0}", hardware.Name);
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        //Console.WriteLine("\tSensor: {0}, value: {1}", sensor.Name, sensor.Value);
                        Console.WriteLine("{0} {1} ={2} ", sensor.Name, sensor.SensorType, sensor.Value);
                    }
                    var disk = new diskDrive();
                    disk.Name = hardware.Name;
                    ListDisk.Add(disk);
                }
            }

            Console.ReadLine();

        }
        public class diskDrive {
            public string Name { get; set; }
            public string Use { get; set; }
            public string Load { get; set; }
        }

    }
}
