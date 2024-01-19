using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gang_of_four.builder
{
    // Client Code
    public class BuilderExample
    {
        public static void computerExample()
        {
            // Using a desktop computer builder
            IComputerBuilder desktopBuilder = new DesktopComputerBuilder();
            ComputerManufacturer manufacturer = new ComputerManufacturer(desktopBuilder);

            // Construct a computer
            manufacturer.ConstructComputer();

            // Get the final computer
            Computer desktopComputer = desktopBuilder.GetComputer();
            Console.WriteLine(desktopComputer);
        }
    }

    // Product
    public class Computer
    {
        public string Processor { get; set; }
        public int RamSize { get; set; }
        public int StorageSize { get; set; }
        public string OperatingSystem { get; set; }

        public override string ToString()
        {
            return $"Computer: {Processor}, {RamSize}GB RAM, {StorageSize}GB Storage, {OperatingSystem}";
        }
    }

    // Builder
    public interface IComputerBuilder
    {
        void BuildProcessor(string processor);
        void BuildRam(int ramSize);
        void BuildStorage(int storageSize);
        void BuildOperatingSystem(string operatingSystem);
        Computer GetComputer();
    }


    // Concrete Builder
    public class DesktopComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public void BuildProcessor(string processor)
        {
            computer.Processor = processor;
        }

        public void BuildRam(int ramSize)
        {
            computer.RamSize = ramSize;
        }

        public void BuildStorage(int storageSize)
        {
            computer.StorageSize = storageSize;
        }

        public void BuildOperatingSystem(string operatingSystem)
        {
            computer.OperatingSystem = operatingSystem;
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }

    // Director
    public class ComputerManufacturer
    {
        private IComputerBuilder computerBuilder;

        public ComputerManufacturer(IComputerBuilder builder)
        {
            this.computerBuilder = builder;
        }

        public void ConstructComputer()
        {
            computerBuilder.BuildProcessor("Intel i7");
            computerBuilder.BuildRam(16);
            computerBuilder.BuildStorage(512);
            computerBuilder.BuildOperatingSystem("Windows 10");
        }
    }




}
