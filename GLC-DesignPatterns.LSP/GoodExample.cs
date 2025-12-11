namespace GLC_DesignPatterns.LSP.GoodExample
{
    public abstract class Pet
    {
        public void Eat()
        {
            Console.WriteLine($"{this.GetType().Name} is eating.");
        }
    }

    public interface IWalkable
    {
        void Walk();
    }

    public class Dog : Pet, IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Dog is walking.");
        }
    }

    public class Cat : Pet, IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Cat is walking.");
        }
    }

    public class Goldfish : Pet
    {

    }
}
