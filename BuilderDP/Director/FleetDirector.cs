using BuilderDP.Builder;

namespace BuilderDP.Director
{
    public class FleetDirector
    {
        public void ConstructSportsCar(ICarBuilder builder)
        {
            builder.SetBrand("Ferrari")
                   .SetEngine("V8 Turbo", 710)
                   .SetTransmission("7-Speed Dual Clutch")
                   .SetColor("Red")
                   .AddSoundSystem();
        }

        public void ConstructSUV(ICarBuilder builder)
        {
            builder.SetBrand("Range Rover")
                   .SetEngine("V6 Diesel", 300)
                   .SetTransmission("8-Speed Automatic")
                   .SetColor("Black")
                   .AddGPS()
                   .AddSunroof();
        }
    }
}
