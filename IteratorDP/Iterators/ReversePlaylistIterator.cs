using IteratorDP.Interfaces;
using IteratorDP.Models;

namespace IteratorDP.Iterators;

public class ReversePlaylistIterator : IIterator<Song>
{
    private readonly List<Song> _songs;
    private int _currentIndex;

    public ReversePlaylistIterator(List<Song> songs)
    {
        _songs = songs;
        _currentIndex = songs.Count;
    }

    public Song Current
    {
        get
        {
            if (_currentIndex < 0 || _currentIndex >= _songs.Count)
                throw new InvalidOperationException("Invalid iterator position.");

            return _songs[_currentIndex];
        }
    }

    public bool MoveNext()
    {
        _currentIndex--;
        return _currentIndex >= 0;
    }

    public void Reset()
    {
        _currentIndex = _songs.Count;
    }

    public bool HasNext()
    {
        return (_currentIndex - 1) >= 0;
    }
}
