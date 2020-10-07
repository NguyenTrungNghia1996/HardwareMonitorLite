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
                    //Console.WriteLine("Hardware: {0}", hardware.Name);
                    string use="", load="",temp="";
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        //Console.WriteLine("\tSensor: {0}, value: {1}", sensor.Name, sensor.Value);
                       // Console.WriteLine("{0} {1} ={2} ", sensor.Name, sensor.SensorType, sensor.Value);
                        if(sensor.SensorType == SensorType.Load && sensor.Name == "Used Space")
                        {
                            
                            use = sensor.Value.GetValueOrDefault().ToString();
                            int i = use.IndexOf('.');
                            use = use.Substring(0, i);
                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "Total Activity")
                        {
                            load = sensor.Value.GetValueOrDefault().ToString();
                            int i = load.IndexOf('.');
                            load = load.Substring(0, i);
                        }
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "Temperature")	    
                        {	       
                            temp = sensor.Value.GetValueOrDefault().ToString();
                            int i = temp.IndexOf('.');
                            temp = temp.Substring(0, i);
                        }
                    }
                    var disk = new diskDrive();
                    disk.Name = hardware.Name;
                    disk.Use = use;
                    disk.Load = load;
                    disk.Temp = temp;
                    ListDisk.Add(disk);
                }
            }
            foreach(var item in ListDisk)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Name, item.Load, item.Use, item.Temp);
            }
            Console.ReadLine();

        }
        public class diskDrive {
            public string Name { get; set; }
            public string Use { get; set; }
            public string Load { get; set; }
            public string Temp { get; set; }
        }

    }
}
