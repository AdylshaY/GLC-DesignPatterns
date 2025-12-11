namespace HasAIsA.BadExample
{
    public class Train : Vehicle
    {
        public override void Backward()
        {
            Console.WriteLine("Train backward");
        }

        public override void Left()
        {
            throw new NotImplementedException();
        }

        public override void Right()
        {
            throw new NotImplementedException();
        }
    }
}
