namespace IteratorDP.Interfaces;

public interface IIterator<T>
{
    bool MoveNext();

    T Current { get; }

    void Reset();

    bool HasNext();
}
