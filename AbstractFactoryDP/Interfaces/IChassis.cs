namespace AbstractFactoryDP.Interfaces
{
    public interface IChassis
    {
        string Material { get; }
        void InstallEngine(IEngine engine);
    }
}
