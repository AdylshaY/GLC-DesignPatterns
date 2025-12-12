using BuilderDP.Models;

namespace BuilderDP.Builder
{
    public interface ICarBuilder
    {
        ICarBuilder SetBrand(string brand);
        ICarBuilder SetEngine(string engineType, int horsePower);
        ICarBuilder SetTransmission(string transmissionType);
        ICarBuilder SetColor(string color);

        ICarBuilder AddSunroof();
        ICarBuilder AddGPS();
        ICarBuilder AddSoundSystem();

        Car Build();
    }
}
