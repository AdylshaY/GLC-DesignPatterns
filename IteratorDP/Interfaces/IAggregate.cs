namespace IteratorDP.Interfaces;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
    
    void Add(T item);
    
    int Count { get; }
}
