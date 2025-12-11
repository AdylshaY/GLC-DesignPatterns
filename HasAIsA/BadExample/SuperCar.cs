namespace HasAIsA.BadExample
{
    public class SuperCar : Vehicle
    {
        public override void Backward()
        {
            Console.WriteLine("Car backward");
        }

        public override void Left()
        {
            Console.WriteLine("SuperCar left");
        }

        public override void Right()
        {
            Console.WriteLine("SuperCar right");
        }
    }
}
