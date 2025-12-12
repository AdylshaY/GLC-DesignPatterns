using AbstractFactoryDP.Interfaces;

namespace AbstractFactoryDP.Products
{
    public class SportTransmission : ITransmission
    {
        public string Type => "Dual Clutch Transmission (DCT)";
        public void TestGearShift()
        {
            Console.WriteLine($"[Test] {Type}: Gear shift verified (Fast response).");
        }
    }

    public class SportEngine : IEngine
    {
        public int HorsePower => 500;

        public void AttachTransmission(ITransmission transmission)
        {
            Console.WriteLine($"[Assembly] Attached {transmission.Type} to Sport Engine.");
        }

        public void Start()
        {
            Console.WriteLine("[System] Sport Engine started. Performance parameters loaded.");
        }
    }

    public class SportChassis : IChassis
    {
        public string Material => "Carbon Fiber";

        public void InstallEngine(IEngine engine)
        {
            Console.WriteLine($"[Assembly] Installed {engine.HorsePower}HP engine into {Material} chassis.");
        }
    }
}
