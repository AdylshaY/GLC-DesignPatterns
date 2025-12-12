namespace BuilderDP.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public List<string> Accessories { get; set; }

        public Car()
        {
            Accessories = new List<string>();
        }

        public void DisplaySpecs()
        {
            Console.WriteLine($"\n--- Car Specifications ---");
            Console.WriteLine($"Brand       : {Brand}");
            Console.WriteLine($"Engine      : {Engine}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Color       : {Color}");
            Console.WriteLine($"Accessories : {(Accessories.Count > 0 ? string.Join(", ", Accessories) : "None")}");
            Console.WriteLine("--------------------------");
        }
    }
}
