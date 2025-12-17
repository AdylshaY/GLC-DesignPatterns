using IteratorDP.Collections;
using IteratorDP.Models;

var myPlaylist = new Playlist { Name = "My Favorites" };

myPlaylist.Add(new Song
{
    Id = 1,
    Title = "Nothing Else Matters",
});

myPlaylist.Add(new Song
{
    Id = 2,
    Title = "Turn the Page",
});

myPlaylist.Add(new Song
{
    Id = 3,
    Title = "Chop Suey",
});

myPlaylist.Add(new Song
{
    Id = 4,
    Title = "Unforgiven",
});

myPlaylist.DisplayPlaylist();

var iterator = myPlaylist.CreateIterator();
while (iterator.MoveNext())
{
    var currentSong = iterator.Current;
    Console.WriteLine($"Playing: {currentSong.Title}");

    if (iterator.HasNext())
    {
        Console.WriteLine("  -> Next song is ready...");
    }
    else
    {
        Console.WriteLine("  -> This is the last song!");
    }
}