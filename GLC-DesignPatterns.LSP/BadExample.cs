namespace GLC_DesignPatterns.LSP.BadExample
{
    public abstract class Pet
    {
        public abstract void Walk();
    }

    public class Dog : Pet
    {
        public override void Walk()
        {
            Console.WriteLine("Dog is walking.");
        }
    }

    public class Cat : Pet
    {
        public override void Walk()
        {
            Console.WriteLine("Cat is walking.");
        }
    }

    public class Goldfish : Pet
    {
        public override void Walk()
        {
            throw new NotSupportedException("Goldfish cannot walk!");
        }
    }
}
