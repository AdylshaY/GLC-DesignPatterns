namespace HasAIsA.BadExample
{
    public class Car : Vehicle
    {
        public override void Backward()
        {
            Console.WriteLine("Car backward");
        }

        public override void Left()
        {
            Console.WriteLine("Car left");
        }

        public override void Right()
        {
            Console.WriteLine("Car right");
        }
    }
}
