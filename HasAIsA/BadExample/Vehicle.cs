namespace HasAIsA.BadExample
{
    public abstract class Vehicle
    {
        public void Forward()
        {
            Console.WriteLine("Forward");
        }

        public abstract void Backward();
        public abstract void Left();
        public abstract void Right();
    }
}
