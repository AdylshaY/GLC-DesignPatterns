using IteratorDP.Interfaces;
using IteratorDP.Iterators;
using IteratorDP.Models;

namespace IteratorDP.Collections;

public class Playlist : IAggregate<Song>
{
    private readonly List<Song> _songs = new();
    public string Name { get; set; } = string.Empty;

    public void Add(Song item)
    {
        _songs.Add(item);
        Console.WriteLine($" '{item.Title}' added to playlist.");
    }

    public int Count => _songs.Count;

    public IIterator<Song> CreateIterator()
    {
        return new PlaylistIterator(_songs);
    }

    public void AddSong(Song song)
    {
        Add(song);
    }

    public void RemoveSong(int songId)
    {
        var song = _songs.FirstOrDefault(s => s.Id == songId);
        if (song != null)
        {
            _songs.Remove(song);
            Console.WriteLine($"'{song.Title}' removed from playlist.");
        }
    }

    public IIterator<Song> CreateReverseIterator()
    {
        return new ReversePlaylistIterator(_songs);
    }

    public void DisplayPlaylist()
    {
        Console.WriteLine($"\n Playlist: {Name}");
        Console.WriteLine(new string('-', 50));

        if (_songs.Count == 0)
        {
            Console.WriteLine("Playlist is empty.");
            return;
        }

        foreach (var song in _songs)
        {
            Console.WriteLine($"  {song}");
        }

        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"Total: {_songs.Count} songs");
    }
}
