using BuilderDP.Models;

namespace BuilderDP.Builder
{
    public class CustomCarBuilder : ICarBuilder
    {
        private Car _car;

        public CustomCarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public ICarBuilder SetBrand(string brand)
        {
            _car.Brand = brand;
            return this;
        }

        public ICarBuilder SetEngine(string engineType, int horsePower)
        {
            _car.Engine = $"{engineType} ({horsePower} HP)";
            return this;
        }

        public ICarBuilder SetTransmission(string transmissionType)
        {
            _car.Transmission = transmissionType;
            return this;
        }

        public ICarBuilder SetColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public ICarBuilder AddSunroof()
        {
            _car.Accessories.Add("Panoramic Sunroof");
            return this;
        }

        public ICarBuilder AddGPS()
        {
            _car.Accessories.Add("Navigation System");
            return this;
        }

        public ICarBuilder AddSoundSystem()
        {
            _car.Accessories.Add("Premium Harman Kardon Sound");
            return this;
        }

        public Car Build()
        {
            Car finishedCar = _car;
            Reset();
            return finishedCar;
        }
    }
}
