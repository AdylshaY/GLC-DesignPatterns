namespace AbstractFactoryDP.Interfaces
{
    public interface IEngine
    {
        int HorsePower { get; }
        void AttachTransmission(ITransmission transmission);
        void Start();
    }
}
