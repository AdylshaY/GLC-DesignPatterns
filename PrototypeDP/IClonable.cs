namespace PrototypeDP
{
    public interface IClonable<T>
    {
        T ShallowCopy();
        T DeepCopy();
    }
}