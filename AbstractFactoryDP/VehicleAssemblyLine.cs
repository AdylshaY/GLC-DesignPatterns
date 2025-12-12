using AbstractFactoryDP.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public class VehicleAssemblyLine
    {
        private readonly IVehicleFactory _factory;

        public VehicleAssemblyLine(IVehicleFactory factory)
        {
            _factory = factory;
        }

        public void BuildAndVerifyVehicle()
        {
            Console.WriteLine("--- Initializing Assembly Process ---");

            var chassis = _factory.CreateChassis();
            var engine = _factory.CreateEngine();
            var transmission = _factory.CreateTransmission();

            chassis.InstallEngine(engine);

            engine.AttachTransmission(transmission);

            engine.Start();
            transmission.TestGearShift();

            Console.WriteLine("--- Assembly Process Completed ---\n");
        }
    }
}
