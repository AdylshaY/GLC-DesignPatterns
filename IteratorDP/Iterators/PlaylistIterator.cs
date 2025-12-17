using IteratorDP.Interfaces;
using IteratorDP.Models;

namespace IteratorDP.Iterators;

public class PlaylistIterator : IIterator<Song>
{
    private readonly List<Song> _songs;
    private int _currentIndex = -1;

    public PlaylistIterator(List<Song> songs)
    {
        _songs = songs;
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
        _currentIndex++;
        return _currentIndex < _songs.Count;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }

    public bool HasNext()
    {
        return (_currentIndex + 1) < _songs.Count;
    }
}
