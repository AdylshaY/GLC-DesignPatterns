using AbstractFactoryDP.Interfaces;

namespace AbstractFactoryDP.Products
{
    public class EconomyTransmission : ITransmission
    {
        public string Type => "Standard Automatic";
        public void TestGearShift()
        {
            Console.WriteLine($"[Test] {Type}: Gear shift verified (Smooth response).");
        }
    }

    public class EconomyEngine : IEngine
    {
        public int HorsePower => 120;

        public void AttachTransmission(ITransmission transmission)
        {
            Console.WriteLine($"[Assembly] Attached {transmission.Type} to Economy Engine.");
        }

        public void Start()
        {
            Console.WriteLine("[System] Economy Engine started. Fuel saving mode active.");
        }
    }

    public class EconomyChassis : IChassis
    {
        public string Material => "Steel";

        public void InstallEngine(IEngine engine)
        {
            Console.WriteLine($"[Assembly] Installed {engine.HorsePower}HP engine into {Material} chassis.");
        }
    }
}
